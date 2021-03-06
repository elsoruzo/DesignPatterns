namespace ConsoleImplementationOfDecorator
{
    using System;
    using System.Collections.Generic;
    using DecoratorPratcicalExample.Models;
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("To exit press E or Press any key to START decorating");
            char command = Console.ReadKey().KeyChar;

            Console.WriteLine("START RUNNING DECORATOR.");
            TodoEvent event1 = new TodoEvent()
            {
                EventType = "FEED THE CAT"
                    ,
                PersonName = "YAKOV"
            };
            TodoEvent event2 = new TodoEvent()
            {
                EventType = "FEED THE BAT"
        ,
                PersonName = "BIAKOV"
            };
            TodoEvent event3 = new TodoEvent()
            {
                EventType = "FEED THE RAT"
        ,
                PersonName = "BRIAKOV"
            };
            TodoEvent event4 = new TodoEvent()
            {
                EventType = "FEED THE SWAT"
        ,
                PersonName = "KULEBIAKOV"
            };
            List<TodoEvent> todos = new List<TodoEvent>();
            todos.Add(event4);
             todos.Add(event3);
            todos.Add(event2);
             todos.Add(event1);
            //Init
            var dbService = new DbService();
            var logService = new LoggerService();
            var messageService = new MessageService();
            var contactService = new ContactService();

            var messageServiceContactDecorator = new MessageServiceContactDecorator(messageService, contactService);

             var logServiceMessageDecorator = new LogServiceMessageDecorator(logService, messageServiceContactDecorator);

            //var logServiceMessageDecorator = new LogServiceMessageDecorator(logService, messageService);

            var dbServiceLogDecorated = new DbServiceLogDecorator(dbService, logServiceMessageDecorator);

            var todoService = new ToDoService(dbServiceLogDecorated);

            //Act
            todoService.Save(todos);

            Console.ReadKey();

        }
    }
}













