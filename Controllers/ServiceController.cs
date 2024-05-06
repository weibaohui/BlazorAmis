using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class ServiceController : Controller
{
    [HttpGet("Data")]
    public object Data(string? keywords)
    {
        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                keywords = keywords,
                date = 1714968410,
                table1 = new object[]
                {
                    new
                    {
                        id = 43668016,
                        text = "Cedarte",
                        progress = 29,
                        type = 4,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 922460,
                        text = "Namare",
                        progress = 5,
                        type = 4,
                        boolean = true,
                        list = new object[] { },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 72759670,
                        text = "Zonapguv",
                        progress = 2,
                        type = 1,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 71456613,
                        text = "Vumjevrek",
                        progress = 62,
                        type = 3,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 99266309,
                        text = "Hilhewod",
                        progress = 26,
                        type = 1,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "izuve,ol ota wut."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 66900480,
                        text = "Holigsud",
                        progress = 71,
                        type = 3,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 64362649,
                        text = "Akjozte",
                        progress = 50,
                        type = 4,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 76946958,
                        text = "Kotibri",
                        progress = 90,
                        type = 3,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 59859024,
                        text = "Geviruca",
                        progress = 99,
                        type = 3,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 45472256,
                        text = "Odponha",
                        progress = 48,
                        type = 3,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    }
                },
                table2 = new object[]
                {
                    new
                    {
                        id = 49032608,
                        text = "Saaminog",
                        progress = 31,
                        type = 4,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 36363431,
                        text = "Fotbifod",
                        progress = 89,
                        type = 3,
                        boolean = true,
                        list = new object[] { },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 64029442,
                        text = "Bopotekiw",
                        progress = 2,
                        type = 1,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 47244670,
                        text = "Gaozsu",
                        progress = 98,
                        type = 5,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 18004762,
                        text = "Sihelgeh",
                        progress = 54,
                        type = 2,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 95075463,
                        text = "Kowavzor",
                        progress = 3,
                        type = 0,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 98910267,
                        text = "Wigurje",
                        progress = 77,
                        type = 4,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 94290348,
                        text = "Fefobete",
                        progress = 79,
                        type = 4,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 42161461,
                        text = "Sawnambo",
                        progress = 39,
                        type = 3,
                        boolean = true,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    },
                    new
                    {
                        id = 33059262,
                        text = "Dejvevsad",
                        progress = 85,
                        type = 3,
                        boolean = false,
                        list = new[]
                        {
                            new
                            {
                                title = "lo",
                                description = " zam secric."
                            },
                            new
                            {
                                title = "komutfu",
                                description = "wjezu jacudi wum. El dodon biuwzus muf ucjejja tuupebe tefi vimevo."
                            }
                        },
                        date = 1714968410,
                        image =
                            "/photo/alice-macaw.jpg"
                    }
                }
            }
        };
        ;

        return data;
    }

    [HttpGet("Fail")]
    public object Fail()
    {
        var data = new
        {
            status = 404,
            msg = "Not Found",
        };

        return data;
    }


    [Route("Schema")]
    public object Schema(string type = "form")
    {
        var curdData = new
        {
            type = "crud",
            draggable = true,
            api = "/api/mock/sample/sample",
            syncLocation = false,
            perPage = 50,
            filter = new
            {
                title = "条件搜索",
                submitText = "",
                controls = new object[]
                {
                    new
                    {
                        type = "text",
                        name = "keywords",
                        placeholder = "通过关键字搜索",
                        addOn = new { label = "搜索", type = "submit" }
                    },
                    new { type = "plain", text = "这里的表单项可以配置多个" }
                }
            },
            bulkActions = new object[]
            {
                new
                {
                    label = "批量删除",
                    actionType = "ajax",
                    api = "delete:/api/mock/sample/$ids",
                    confirmText = "确定要批量删除?"
                },
                new
                {
                    label = "批量修改",
                    actionType = "dialog",
                    dialog = new
                    {
                        title = "批量编辑",
                        name = "sample-bulk-edit",
                        body = new
                        {
                            type = "form",
                            api = "/api/mock/sample/bulkUpdate2",
                            controls = new object[]
                            {
                                new { type = "hidden", name = "ids" },
                                new { type = "text", name = "engine", label = "Engine" }
                            }
                        }
                    }
                }
            },
            quickSaveApi = "/api/mock/sample/bulkUpdate",
            quickSaveItemApi = "/api/mock/sample/$id",
            columns = new object[]
            {
                new { name = "id", label = "ID", width = 20, sortable = true, type = "text", toggled = true },
                new
                {
                    name = "engine", label = "Rendering engine", sortable = true, searchable = true, type = "text",
                    toggled = true
                },
                new { name = "browser", label = "Browser", sortable = true, type = "text", toggled = true },
                new { name = "platform", label = "Platform(s)", sortable = true, type = "text", toggled = true },
                new { name = "version", label = "Engine version", quickEdit = true, type = "text", toggled = true },
                new
                {
                    name = "grade",
                    label = "CSS grade",
                    quickEdit = new
                    {
                        mode = "inline", type = "select", options = new[] { "A", "B", "C", "D", "X" },
                        saveImmediately = true
                    },
                    type = "text",
                    toggled = true
                },
                new
                {
                    type = "operation",
                    label = "操作",
                    width = 130,
                    buttons = new object[]
                    {
                        new
                        {
                            type = "button",
                            icon = "fa fa-eye",
                            actionType = "dialog",
                            dialog = new
                            {
                                title = "查看",
                                body = new
                                {
                                    type = "form",
                                    controls = new object[]
                                    {
                                        new { type = "static", name = "engine", label = "Engine" },
                                        new { type = "divider" },
                                        new { type = "static", name = "browser", label = "Browser" },
                                        new { type = "divider" },
                                        new { type = "static", name = "platform", label = "Platform(s)" },
                                        new { type = "divider" },
                                        new { type = "static", name = "version", label = "Engine version" },
                                        new { type = "divider" },
                                        new { type = "static", name = "grade", label = "CSS grade" },
                                        new { type = "divider" },
                                        new
                                        {
                                            type = "html", html = "<p>添加其他 <span>Html 片段</span> 需要支持变量替换（todo）.</p>"
                                        }
                                    }
                                }
                            }
                        },
                        new
                        {
                            type = "button",
                            icon = "fa fa-pencil",
                            actionType = "dialog",
                            dialog = new
                            {
                                title = "编辑",
                                body = new
                                {
                                    type = "form",
                                    name = "sample-edit-form",
                                    api = "/api/mock/sample/$id",
                                    controls = new object[]
                                    {
                                        new { type = "text", name = "engine", label = "Engine", required = true },
                                        new { type = "divider" },
                                        new { type = "text", name = "browser", label = "Browser", required = true },
                                        new { type = "divider" },
                                        new
                                        {
                                            type = "text", name = "platform", label = "Platform(s)", required = true
                                        },
                                        new { type = "divider" },
                                        new { type = "text", name = "version", label = "Engine version" },
                                        new { type = "divider" },
                                        new { type = "text", name = "grade", label = "CSS grade" }
                                    }
                                }
                            }
                        },
                        new
                        {
                            type = "button",
                            icon = "fa fa-times text-danger",
                            actionType = "ajax",
                            confirmText = "您确认要删除?",
                            api = "delete:/api/mock/sample/$id"
                        }
                    }
                }
            }
        };
        var tabData = new
        {
            type = "tabs",
            tabs = new[] { new { title = "TabA", body = "卡片A内容" }, new { title = "TabB", body = "卡片B内容" } }
        };
        var formData = new
        {
            type = "form",
            api = "/api/mock/form/saveForm?waitSeconds=2",
            title = "常规模式",
            mode = "normal",
            controls = new object[]
            {
                new
                {
                    type = "email",
                    name = "email",
                    required = true,
                    placeholder = "请输入邮箱",
                    label = "邮箱"
                },
                new
                {
                    type = "password",
                    name = "password",
                    label = "密码",
                    required = true,
                    placeholder = "请输入密码"
                },
                new { type = "checkbox", name = "rememberMe", label = "记住登录" },
                new { type = "static", value = "AMIS_HOST" }
            }
        };

        object content = type switch
        {
            "tabs" => tabData,
            "crud" => curdData,
            _ => formData,
        };

        var data = new
        {
            status = 0,
            msg = "",
            data = content
        };


        return data;
    }

    [Route("Form")]
    public object Form(string tpl = "tpl1")
    {
        var tpl1Data =
            new
            {
                data = new
                {
                    dy_1 = "还可以更新值"
                },
                controls = new object[]
                {
                    new
                    {
                        type = "text",
                        label = "动态字段1",
                        name = "dy_1",
                        required = true
                    },
                    new
                    {
                        type = "text",
                        label = "动态字段2",
                        name = "dy_2"
                    }
                }
            };
        var tpl2Data = new
        {
            type = "panel",
            title = "不是非得是 controls",
            body = "也可以是其他渲染器"
        };
        var tpl3Data = new
        {
            type = "tpl",
            tpl = "简单点好。"
        };

        object content = tpl switch
        {
            "tpl1" => tpl1Data,
            "tpl2" => tpl2Data,
            "tpl3" => tpl3Data,
            _ => tpl1Data,
        };

        var data = new
        {
            status = 0,
            msg = "",
            data = content
        };


        return data;
    }
}
