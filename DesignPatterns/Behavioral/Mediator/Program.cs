using System;
using Autofac;
using Mediator.Chat;
using MediatorPattern.PingMediatR;
using MediatR;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = DependencyInjection.Configure();
            var mediator = container.Resolve<IMediator>();

            //Demo.ChatRoom();
            Demo.Ping(mediator);
        }
    }

    public static class Demo
    {
        public static void ChatRoom()
        {
            var room = new ChatRoom();

            var john = new Person("John");
            var jane = new Person("Jane");

            room.Join(john);
            room.Join(jane);

            john.Say("hi room");
            jane.Say("oh, hey john");

            var simon = new Person("Simon");
            room.Join(simon);
            simon.Say("hi everyone!");

            jane.PrivateMessage("Simon", "glad you could join us!");
        }

        public static async void Ping(IMediator mediator)
        {
            var resonse = await mediator.Send(new PingRequest
            {
                From = "me"
            });

            Console.WriteLine($"Pring from: {resonse.From} is {resonse.Correct} at {resonse.TimeStamp}");
        }
    }

    public static class DependencyInjection
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MediatR.Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                .AsImplementedInterfaces();

            return builder.Build();

        }
    }
}
