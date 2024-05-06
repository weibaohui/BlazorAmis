# BlazorAmis
使用Blazor 集成 百度Amis低代码平台

1. 官方示例移植
2. 接口移植
3. json的定义上使用了匿名类的方式进行表达，非常符合c#使用习惯

[BlazorServer版本](https://github.com/weibaohui/BlazorAmis)
[BlazorWasm版本](https://github.com/weibaohui/BlazorAmisWasm)

#体验
```docker
docker run -it --rm -p 7777:8080 blazoramis
```

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
