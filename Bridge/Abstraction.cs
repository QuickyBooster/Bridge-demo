
namespace Bridge
{
	class Abstraction
	{
		protected IImplementor _implementation;

		public Abstraction(IImplementor implementation)
		{
			this._implementation = implementation;
		}

		public virtual string Operation()
		{
			return "Abstract: Base operation with:\n" +
				_implementation.OperationImplementation();
		}
	}


	class ExtendedAbstraction : Abstraction
	{
		public ExtendedAbstraction(IImplementor implementation) : base(implementation)
		{
		}

		public override string Operation()
		{
			return "ExtendedAbstraction: Extended operation with:\n" +
				base._implementation.OperationImplementation();
		}
	}

}
