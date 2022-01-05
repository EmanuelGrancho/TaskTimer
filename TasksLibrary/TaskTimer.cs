namespace TasksLibrary
{
    public class TaskTimer
    {
        private static string _projectName;
        private static DateTime _taskEndDate;
        private static List<string> _whatToDo;

        private static DateTime _startDate;
        private static DateTime _endDate;

        public TaskTimer(string projectName, DateTime taskEndDate, List<string> whatToDo)
        {
            _whatToDo = new List<string>(whatToDo);
            _taskEndDate = taskEndDate;
            _projectName = projectName;
        }

        public void Start()
        {
            _startDate = DateTime.Now;
        }

        public void Stop()
        {
            _endDate = DateTime.Now;
        }

        public TimeSpan TaskEvaluation()
        {
            return _endDate - _startDate;
        }
    }
}