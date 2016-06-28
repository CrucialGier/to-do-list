using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class Task
  {
    private string _description;
    private static List<string> _instance = new List<string> {};
    public Task (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<string> GetAll()
    {
      return _instance;
    }
    public void Save()
    {
      _instance.Add(_description);
    }
  }
}
