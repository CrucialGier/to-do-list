using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class Task
  {
    private string _description;
    private static List<Task> _instances = new List<Task> {};
    private int _id;

    public Task (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Task> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int GetId()
    {
      return _id;
    }
    public static Task Find(int id)
    {
      return _instances[id - 1];
    }
  }
}
