namespace ClassLibrary1.Repository.Infrastructure
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private EmployeeContext dataContext;
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        protected EmployeeContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        public void Commit()
        {
            DataContext.Commit();
        }
    }
}
