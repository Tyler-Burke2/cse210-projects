public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyy-MM-dd"); // no commas now
    }

    public string Csv()
    {
        return $"{Date},{Prompt.Replace(",", ";")},{Response.Replace(",", ";")}";
    }
}
