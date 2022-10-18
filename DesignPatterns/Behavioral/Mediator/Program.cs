using System;
using Mediator.Chat;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.ChatRoom();
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
    }
}
