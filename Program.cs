using System;

namespace Messages
{
    public abstract class User
    {
        public abstract string Operation();
    }

    class ConsoleUser : User
    {
        public override string Operation()
        {
            return "ConsoleUser";
        }
    }

    abstract class Message : User
    {
        protected User _user;

        public Message(User user)
        {
            this._user = user;
        }

        public void SetComponent(User user)
        {
            this._user = user;
        }


        public override string Operation()
        {
            if (this._user != null)
            {
                return this._user.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    
    class AddMessage : Message
    {
        public AddMessage(User comp) : base(comp)
        {
        }

        
        public override string Operation()
        {
            return $"AddMessage({base.Operation()})";
        }
    }

    class SendingMessage : Message
    {
        public SendingMessage(User comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"SendinMessage({base.Operation()})";
        }
    }
    
    public class Client
    {
        public void ClientCode(User user)
        {
            Console.WriteLine("RESULT: " + user.Operation());
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConsoleUser();
            Console.WriteLine("Виберіть метод розсилки:");
            client.ClientCode(simple);
            Console.WriteLine();

            AddMessage decorator1 = new AddMessage(simple);
            SendingMessage decorator2 = new SendingMessage(decorator1);
            Console.WriteLine("Розсилка:",decorator1);
            client.ClientCode(decorator2);
        }
    }
}
