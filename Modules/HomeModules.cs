using Nancy;
using ToDoList.Objects;
using System.Collections.Generic;

namespace ToDoList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_task.cshtml"];
      Get["/view_all_tasks"] = _ => {
        List<Task> allTasks = Task.GetAll();
        return View["view_all_tasks.cshtml", allTasks];
      };
      Post["/task_added"] = _ => {
        Task newTask = new Task (Request.Form["new-task"]);
        return View["task_added.cshtml", newTask];
      };
      Get["/tasks_cleared"] = _ => {
        Task.ClearAll();
        return View["tasks_cleared.cshtml"];
      };
      Get["/tasks/{id}"] = parameters => {
        Task task = Task.Find(parameters.id);
        return View["/task.cshtml", task];
      };
    }
  }
}
