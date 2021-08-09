namespace P02._WorkerAndManager_Before
{
    public class Manager
    {
        public Manager(IWorkable worker)
        {            
            worker.Work();
        }
    }
}
