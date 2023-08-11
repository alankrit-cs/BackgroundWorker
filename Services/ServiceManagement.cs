namespace BackgroundWorker.Services
{
    public class ServiceManagement : IServiceManagement
    {
        public void GenerateMerchandise()
        {
            Console.WriteLine($"Generate Merchandise: Long running task {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}");
        }

        public void SendMail()
        {
            Console.WriteLine($"Send Mail: Short running task {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}");
        }

        public void SyncData()
        {
            Console.WriteLine($"Sync Data: Short running task {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}");
        }

        public void UpdateDatabase()
        {
            Console.WriteLine($"Update Database: Long running task {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}");
        }
    }
}
