
namespace Bridge
{
	public interface IImplementor
	{
		string OperationImplementation();
	}


	class ConcreteImplementationA : IImplementor
	{
		public string OperationImplementation()
		{
			return "ConcreteImplementationA: The result in platform A.\n";
		}
	}

	class ConcreteImplementationB : IImplementor
	{
		public string OperationImplementation()
		{
			return "ConcreteImplementationB: The result in platform B.\n";
		}
	}
}
