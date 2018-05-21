namespace JiraDashboard.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly JiraDashboardDbContext _context;

        public InitialHostDbBuilder(JiraDashboardDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
