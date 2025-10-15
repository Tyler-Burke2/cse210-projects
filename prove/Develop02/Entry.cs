public class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }

    public string GetDate()
    {
        return _date;
    }

    public void UpdateResponse(string newResponse)
    {
        _response = newResponse;
    }

    public string Csv()
    {
        return $"{_date},{_prompt.Replace(",", ";")},{_response.Replace(",", ";")}";
    }
}
