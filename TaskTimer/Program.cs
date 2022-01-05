using TasksLibrary;

DateTime estimatedTimeToFinishTask = DateTime.Now.AddSeconds(5);
List<string> whatToDo = new List<string>() { "Task A","Task B","Task C","Task D"};

TaskTimer taskTimer = new TaskTimer("projectA", estimatedTimeToFinishTask, whatToDo);

taskTimer.Start();

Thread.Sleep(2000);

taskTimer.Stop();

Console.WriteLine($"Estimated date: {estimatedTimeToFinishTask}");
Console.WriteLine($"Duration: {taskTimer.TaskEvaluation().TotalSeconds} s");