namespace Bridge
{

	class Client
	{
		public void ClientCode(TiviAbstraction abstraction)
		{
			Console.Write(abstraction.OperarionF());
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client();

			TiviAbstraction abstraction;
			abstraction = new TiviAbstraction(new SamsungRemote());
			client.ClientCode(abstraction);

			Console.WriteLine();

			abstraction = new SamsungTV(new LGRemote());
			client.ClientCode(abstraction);
		}
	}
}