namespace DesignPatterns.Mediator
{
    // Mediator Interface
    internal interface IChatRoomMediator
    {
        void ShowMessage(string user, string message);
    }

    // Concrete Mediator
    internal class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(string user, string message)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {user}: {message}");
        }
    }

    // Colleague Abstract Class
    internal abstract class User
    {
        protected IChatRoomMediator _mediator;
        protected string _name;

        protected User(IChatRoomMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void Send(string message);
    }

    // Concrete Colleague
    internal class ChatUser : User
    {
        public ChatUser(IChatRoomMediator mediator, string name) : base(mediator, name) { }

        public override void Send(string message)
        {
            _mediator.ShowMessage(_name, message);
        }
    }

    // Demo Class
    internal class MediatorDemo
    {
        public static void Main(string[] args)
        {
            IChatRoomMediator chatRoom = new ChatRoom();

            User user1 = new ChatUser(chatRoom, "Alice");
            User user2 = new ChatUser(chatRoom, "Bob");

            user1.Send("Hi Bob!");
            user2.Send("Hello Alice!");
        }
    }
}
