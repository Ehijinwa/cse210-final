class Records {
    private string _prompt;
    public List<Summary> summaries {get; set;}



    
    public Records() {
        
        _prompt = "How long did you exercise for? What exercise did you do today? How much calories did you burn?";

        summaries = new List<Summary>();
        
    }

    public string GetPrompt() {
        
        return _prompt;
    }
    public string GetResponse()
    {
        return Console.ReadLine();
    }

    public void Display()
    {
        Console.Clear();
        foreach(var entry in summaries)
        {
            entry.Display();
        }
        Console.WriteLine();
    }
    public void AddEntry(string prompt, string response){
        Summary myEntry = new Summary(prompt, response);
        summaries.Add(myEntry);
    }

}