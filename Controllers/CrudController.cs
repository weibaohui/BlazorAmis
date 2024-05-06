using Microsoft.AspNetCore.Mvc;

namespace BlazorAmis.Controllers;

[ApiController]
[Route("Api/Mock/[controller]")]
public class CrudController
{
    [HttpGet("Dynamic")]
    public object Dynamic(int? waitSeconds)
    {
        if (waitSeconds != null)
        {
            Thread.Sleep(waitSeconds.Value * 1000);
        }

        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                count = 57,
                rows = new[]
                {
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 4.0",
                        platform = "Win 95+",
                        version = "4",
                        grade = "X",
                        id = 1
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 5.0",
                        platform = "Win 95+",
                        version = "5",
                        grade = "C",
                        id = 2
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 5.5",
                        platform = "Win 95+",
                        version = "5.5",
                        grade = "A",
                        id = 3
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 6",
                        platform = "Win 98+",
                        version = "6",
                        grade = "A",
                        id = 4
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 7",
                        platform = "Win XP SP2+",
                        version = "7",
                        grade = "A",
                        id = 5
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "AOL browser (AOL desktop)",
                        platform = "Win XP",
                        version = "6",
                        grade = "A",
                        id = 6
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 1.0",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.7",
                        grade = "A",
                        id = 7
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 1.5",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.8",
                        grade = "A",
                        id = 8
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 2.0",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.8",
                        grade = "A",
                        id = 9
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 3.0",
                        platform = "Win 2k+ / OSX.3+",
                        version = "1.9",
                        grade = "A",
                        id = 10
                    }
                },
                columns = new[]
                {
                    new
                    {
                        label = "ID",
                        name = "id"
                    },
                    new
                    {
                        label = "引擎",
                        name = "engine"
                    },
                    new
                    {
                        label = "浏览器",
                        name = "browser"
                    },
                    new
                    {
                        label = "平台",
                        name = "platform"
                    }
                }
            }
        };
        return data;
    }

    [HttpGet("InitData")]
    public object InitData(string? keywords)
    {
        var data = new
        {
            status = 0,
            msg = "",
            data = new
            {
                title = "Test Page Component",
                date = "2017-10-13",
                keywords
            }
        };
        return data;
    }

    [HttpGet("tableWithChildren")]
    public object TableWithChildren(string? keywords)
    {
        var data = new
        {
            status = 0,
            msg = "ok",
            data = new
            {
                count = 57,
                rows = new object[]
                {
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 4.0",
                        platform = "Win 95+",
                        version = "4",
                        grade = "X",
                        id = 1
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 5.0",
                        platform = "Win 95+",
                        version = "5",
                        grade = "C",
                        id = 2,
                        children = new[]
                        {
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 4.0",
                                platform = "Win 95+",
                                version = "4",
                                grade = "X",
                                id = 201,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 2101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 2202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 2303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 5.0",
                                platform = "Win 95+",
                                version = "5",
                                grade = "C",
                                id = 202,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 2101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 2202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 2303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Other browsers",
                                browser = "All others",
                                platform = "-",
                                version = "-",
                                grade = "U",
                                id = 203,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 2101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 2202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 2303
                                    }
                                }
                            }
                        }
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 5.5",
                        platform = "Win 95+",
                        version = "5.5",
                        grade = "A",
                        id = 3
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 6",
                        platform = "Win 98+",
                        version = "6",
                        grade = "A",
                        id = 4,
                        children = new[]
                        {
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 4.0",
                                platform = "Win 95+",
                                version = "4",
                                grade = "X",
                                id = 401,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 4101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 4202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 4303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 5.0",
                                platform = "Win 95+",
                                version = "5",
                                grade = "C",
                                id = 402,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 4101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 4202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 4303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Other browsers",
                                browser = "All others",
                                platform = "-",
                                version = "-",
                                grade = "U",
                                id = 403,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 4101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 4202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 4303
                                    }
                                }
                            }
                        }
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "Internet Explorer 7",
                        platform = "Win XP SP2+",
                        version = "7",
                        grade = "A",
                        id = 5
                    },
                    new
                    {
                        engine = "Trident",
                        browser = "AOL browser (AOL desktop)",
                        platform = "Win XP",
                        version = "6",
                        grade = "A",
                        id = 6
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 1.0",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.7",
                        grade = "A",
                        id = 7,
                        children = new[]
                        {
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 4.0",
                                platform = "Win 95+",
                                version = "4",
                                grade = "X",
                                id = 701,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 7101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 7202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 7303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 5.0",
                                platform = "Win 95+",
                                version = "5",
                                grade = "C",
                                id = 702,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 7101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 7202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 7303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Other browsers",
                                browser = "All others",
                                platform = "-",
                                version = "-",
                                grade = "U",
                                id = 703,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 7101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 7202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 7303
                                    }
                                }
                            }
                        }
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 1.5",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.8",
                        grade = "A",
                        id = 8
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 2.0",
                        platform = "Win 98+ / OSX.2+",
                        version = "1.8",
                        grade = "A",
                        id = 9
                    },
                    new
                    {
                        engine = "Gecko",
                        browser = "Firefox 3.0",
                        platform = "Win 2k+ / OSX.3+",
                        version = "1.9",
                        grade = "A",
                        id = 10,
                        children = new[]
                        {
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 4.0",
                                platform = "Win 95+",
                                version = "4",
                                grade = "X",
                                id = 1001,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 10101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 10202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 10303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Trident",
                                browser = "Internet Explorer 5.0",
                                platform = "Win 95+",
                                version = "5",
                                grade = "C",
                                id = 1002,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 10101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 10202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 10303
                                    }
                                }
                            },
                            new
                            {
                                engine = "Other browsers",
                                browser = "All others",
                                platform = "-",
                                version = "-",
                                grade = "U",
                                id = 1003,
                                children = new[]
                                {
                                    new
                                    {
                                        engine = "Trident",
                                        browser = "Internet Explorer 4.0",
                                        platform = "Win 95+",
                                        version = "4",
                                        grade = "X",
                                        id = 10101
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "5",
                                        grade = "C",
                                        id = 10202
                                    },
                                    new
                                    {
                                        engine = "Misc",
                                        browser = "Internet Explorer 5.0",
                                        platform = "Win 95+",
                                        version = "1",
                                        grade = "A",
                                        id = 10303
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };

        return data;
    }
}
