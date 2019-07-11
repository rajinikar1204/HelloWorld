//-----------------------------------------------------------------------
namespace ConsoleApp.Application
{
    using ConsoleApp.Services;
    using HelloWorldInfrastructure.FrameworkWrappers;
    using HelloWorldInfrastructure.Services;
    using LightInject;
    using RestSharp;
    
    public class Container
    {
        
        public static void Main(string[] args)
        {
            
            using (var container = new ServiceContainer())
            {
                // Configure depenency injection
                container.Register<IHelloWorld, HelloWorld>();
                container.Register<IAppSettings, ConfigAppSettings>();
                container.Register<IConsole, SystemConsole>();
                container.Register<ILogger, ConsoleLogger>();
                container.Register<IUri, SystemUri>();
                container.Register<IHelloWorldWebServ, HelloWorldWebServ>();
                container.RegisterInstance(typeof(IRestClient), new RestClient());
                container.RegisterInstance(typeof(IRestRequest), new RestRequest());

                // Run the main program
                container.GetInstance<IHelloWorld>().Run(args);
            }
        }
    }
}