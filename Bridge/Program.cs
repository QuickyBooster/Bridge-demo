namespace Bridge
{

	class Client
	{
		public void ClientCode(Abstraction abstraction)
		{
			Console.Write(abstraction.Operation());
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client();

			Abstraction abstraction;
			abstraction = new Abstraction(new ConcreteImplementationA());
			client.ClientCode(abstraction);

			Console.WriteLine();

			abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
			client.ClientCode(abstraction);
		}
	}
}