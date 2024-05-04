namespace BlazorAmis.Controllers;
public class Row
{
    public string engine { get; set; }
    public string browser { get; set; }
    public string platform { get; set; }
    public string version { get; set; }
    public string grade { get; set; }
    public string badgeText { get; set; }
    public int id { get; set; }
}

public class Data
{
    public int count { get; set; }
    public List<Row> rows { get; set; }
}

public class Root
{
    public int status { get; set; }
    public string msg { get; set; }
    public Data data { get; set; }
}
