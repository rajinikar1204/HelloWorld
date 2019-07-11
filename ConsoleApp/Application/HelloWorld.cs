
namespace ConsoleApp.Application
{
    using ConsoleApp.Services;
    using HelloWorldInfrastructure.Services;
    public class HelloWorld : IHelloWorld
    {
        private readonly IHelloWorldWebServ helloWorldWebService;
        
        private readonly ILogger logger;

        
        public HelloWorld(IHelloWorldWebServ helloWorldWebService, ILogger logger)
        {
            this.helloWorldWebService = helloWorldWebService;
            this.logger = logger;
        }

        
        public void Run(string[] arguments)
        {
            
            var data = this.helloWorldWebService.GetData();

            
            this.logger.Info(data != null ? data.Data1 : "No data was found!", null);
        }
    }
}