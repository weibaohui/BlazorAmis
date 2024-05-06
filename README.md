# BlazorAmis
使用Blazor 集成 百度Amis低代码平台
[BlazorServer版本](https://github.com/weibaohui/BlazorAmis)
[BlazorWasm版本](https://github.com/weibaohui/BlazorAmisWasm)

# 官方Amis页面
[文档](https://aisuda.bce.baidu.com/amis/zh-CN/docs/index)
[示例](https://aisuda.bce.baidu.com/amis/examples/index)
[可视化编辑器](https://aisuda.github.io/amis-editor-demo/#/hello-world)
[仓库](https://github.com/baidu/amis)

# 特性
<p>百度Amis使用json表达页面及功能。</p>
<p>Blazor 可以使用 C# 匿名类进行json的对等表达。</p>
<p>Blazor + Amis = 生产效率大幅提升</p>

# 项目进展
1. 官方示例移植
2. 接口移植
3. json的定义上使用了匿名类的方式进行表达，非常符合c#使用习惯
4. 有两个json配置超长的页面移植进展90%，尚未完成


#体验
```docker
docker run -it --rm -p 7777:8080 ghcr.io/weibaohui/blazoramis
```
访问7777端口

# 使用
```csharp
<Amis Obj="GetObj()"></Amis>
```
```csharp
 return new
        {
            type = "page",
            title = "表单页面",
            body = new
            {
                type = "form",
                mode = "horizontal",
                api = "/saveForm",
                body = new[]
                {
                    new { label = "Name", type = "input-text", name = "name" },
                    new { label = "Email", type = "input-email", name = "email" }
                }
            }
        };
```

原始JSON
```js
var json={
          type: 'page',
          title: '表单页面',
          body: {
            type: 'form',
            mode: 'horizontal',
            api: '/saveForm',
            body: [
              {
                label: 'Name',
                type: 'input-text',
                name: 'name'
              },
              {
                label: 'Email',
                type: 'input-email',
                name: 'email'
              }
            ]
          }
        }
```
展示效果
<img src="img/blazor-amis.png">
