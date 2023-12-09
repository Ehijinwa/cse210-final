using System.Text.Json.Serialization;

public class Summary {
    public string _date {get; set;}
    public string _prompt {get; set;}
    public string _response {get; set;}

    public Summary(){}
    public Summary(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToShortDateString();
    }
    public void Display(){
        Console.WriteLine($"Date:{_date} \nprompt:{_prompt} {_response}");
    }
    public void Load(string[]entrysome)
    {
        _date = entrysome[0];
        _prompt = entrysome[1];
        _response = entrysome[2];
    }
    public string Some()
    {
        return $"Date:{_date}-prompt:{_prompt} {_response}";
    }
}