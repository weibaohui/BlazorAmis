using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace BlazorAmis.Service;

public class ConvertService
{
    public static string JsObj2Json(string inputStr)
    {
        // 输入的字符串
        // string inputStr = @"
        // {
        //   type: 'page',
        //   title: '表单页面',
        //   body: [
        //     {
        //       type: 'form',
        //       mode: 'horizontal',
        //       api: '/api/mock2/form/saveForm',
        //       body: [
        //         {
        //           label: 'Name',
        //           type: 'input-text',
        //           name: 'name'
        //         },
        //         {
        //           label: 'Email',
        //           type: 'input-email',
        //           placeholder: '请输入邮箱地址',
        //           name: 'email'
        //         }
        //       ]
        //     }
        //   ]
        // }";
// 将输入的字符串解析为 JsonNode
        JsonNode rootNode = JsonNode.Parse(inputStr);

        // 输出格式化后的 JSON 字符串
        string formattedJson = rootNode.ToJsonString(JsonSerializerOptions.Default);
        Console.WriteLine(formattedJson);
        return formattedJson;
    }

    public static string NormalizeJson(string jsonString)
    {
        jsonString = NormalizeKeys(jsonString);
        jsonString = NormalizeValues(jsonString);
        jsonString = NormalizeArraysValues(jsonString);
        jsonString = RemoveSingleLineComments(jsonString);
        jsonString = RemoveFunctionCalls(jsonString, "__uri");
        jsonString = RemoveBacktickStrings(jsonString);
        return jsonString;
    }

    private static string RemoveBacktickStrings(string jsonString)
    {
        string pattern = @"`([^`]*)`"; // 匹配``包裹的内容
        string cleanedJsonString = Regex.Replace(jsonString, pattern, m =>
        {
            string value = m.Groups[1].Value; // 获取匹配到的内容
            value = value.Replace("\\", "\\\\"); // 将反斜杠转义为双反斜杠
            value = value.Replace("\"", "\\\""); // 将双引号转义为转义双引号
            value = value.Replace("\r", ""); // 删除回车符
            value = value.Replace("\n", ""); // 删除换行符
            return "\"" + value + "\""; // 返回处理后的内容
        });
        return cleanedJsonString;
    }

    private static string RemoveFunctionCalls(string jsonString, string functionName)
    {
        string pattern = functionName + @"\(([^)]*)\)";
        // return Regex.Replace(jsonString, pattern, "$1");
        string cleanedJsonString = Regex.Replace(jsonString, pattern, m => m.Groups[1].Value.Replace("'", "\""));
        return cleanedJsonString;
    }

    private static string RemoveSingleLineComments(string jsonString)
    {
        // 匹配注释（以 // 开头的行）
        string pattern = @"^\s*//.*?$";
        string cleanedJsonString = Regex.Replace(jsonString, pattern, "", RegexOptions.Multiline);
        return cleanedJsonString;

    }

    private static string NormalizeKeys(string jsonString)
    {
        string pattern = @"(?<=\s|^)(\w+)\s*:";
        string replacement = @"""$1"":";


        // string pattern = @"(?<key>\b\w+\b)\s*:";
        // string replacement = @"""${key}"":";
        return Regex.Replace(jsonString, pattern, replacement);
    }

    private static string NormalizeValues(string jsonString)
    {
        //{
        //     type: 'input-date',
        //     name: 'starttime1',
        //     maxDate: '${endtime1}',
        //     visibleOn: "data.range1 == 'custom'",
        //     mode: 'inline'
        // },
        // {
        //     name: 'repeatCount',
        //     type: 'input-range',
        //     label: false,
        //     visibleOn: 'data.repeatUnit == "year"'
        // },
        string pattern = @": '([^']*)'";
        // var replacement = Regex.Replace(jsonString, pattern, @": ""$1""");
        // return replacement;
        string cleanedJsonString = Regex.Replace(jsonString, pattern, m =>
        {
            var value = m.Groups[1].Value;
            if (value.Contains("\""))
            {
                value = value.Replace("\"", "\\\"");
            }

            return ": \"" + value + "\"";
        });
        return cleanedJsonString;
    }

    static string NormalizeArraysValues(string jsonString)
    {
        string pattern = @": \s*\[([^\[\]]*)\]"; // 匹配 options 属性后的数组内容
        string cleanedJsonString = Regex.Replace(jsonString, pattern, m =>
        {
            string[] items = m.Groups[1].Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries); // 分割内容
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = items[i].Trim().Replace("'", "\""); // 替换单引号为双引号，并使用转义字符
            }

            string newValue = "[" + string.Join(",", items) + "]"; // 重新组合为数组形式
            return ": " + newValue; // 返回处理后的数组内容
        });
        return cleanedJsonString;
    }

    static string AddQuotesToKeys(string input)
    {
        // 在每个冒号之前和每个逗号之前添加双引号
        input = System.Text.RegularExpressions.Regex.Replace(input, @"([\,\{\[])(\w+)",
            m => $"{m.Groups[1]}\"{m.Groups[2]}\"");
        return input;
    }

    public static string Test(string json)
    {
        string jsonString = @"
        {
            ""type"": ""page"",
            ""title"": ""表单页面"",
            ""body"": [
                {
                    ""type"": ""form"",
                    ""mode"": ""horizontal"",
                    ""api"": ""https://3xsw4ap8wah59.cfc-execute.bj.baidubce.com/api/amis-mock/mock2/form/saveForm"",
                    ""body"": [
                        {
                            ""label"": ""Name"",
                            ""type"": ""input-text"",
                            ""name"": ""name""
                        },
                        {
                            ""label"": ""Email"",
                            ""type"": ""input-email"",
                            ""placeholder"": ""请输入邮箱地址"",
                            ""name"": ""email""
                        }
                    ]
                }
            ]
        }";

        string csharpCode = ConvertJsonToCSharpAnonymousClass(json, "data");
        Console.WriteLine(csharpCode);
        return csharpCode;
    }

    static string ConvertJsonToCSharpAnonymousClass(string json, string className)
    {
        JsonNode root = JsonNode.Parse(json);
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"var {className} = new");
        sb.AppendLine("{");

        GeneratePropertyAssignments(sb, root);

        sb.AppendLine("};");

        return sb.ToString();
    }

    static void GeneratePropertyAssignments(StringBuilder sb, JsonNode node, int indentation = 1)
    {
        if (node is JsonObject jsonObject)
        {

            foreach (var property in jsonObject)
            {
                string propertyName = property.Key;
                JsonNode propertyValue = property.Value;
                sb.Append('\t', indentation);
                sb.Append(propertyName);
                sb.Append(" = ");

                if (propertyValue is JsonObject)
                {
                    sb.AppendLine("new");
                    sb.Append('\t', indentation);
                    sb.AppendLine("{");
                    GeneratePropertyAssignments(sb, propertyValue, indentation + 1);
                    sb.Append('\t', indentation);
                    sb.AppendLine("},");
                }
                else if (propertyValue is JsonArray)
                {
                    sb.AppendLine("new object[]");
                    sb.Append('\t', indentation);
                    sb.AppendLine("{");
                    foreach (var item in (JsonArray)propertyValue)
                    {
                        sb.AppendLine("new {");
                        GeneratePropertyAssignments(sb, item, indentation + 1);
                        sb.AppendLine("},");

                    }

                    sb.Append('\t', indentation);
                    sb.AppendLine("},");
                }

                else
                {
                    sb.AppendLine($"\"{propertyValue}\",");
                }
            }

        }
        else
        {
            sb.AppendLine($"\"{node}\",");
        }
    }
}
