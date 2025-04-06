
using Microsoft.Extensions.DependencyInjection;


//Creating a DI Container
var serviceProvider = new ServiceCollection()
.AddSingleton<IMessageService, ConsoleMessageService>()
.BuildServiceProvider();


//Get and use the service via IMessageService
var messageService = serviceProvider.GetService<IMessageService>();
messageService?.SendMessage("Dependency injection worked successfully!");