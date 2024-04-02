
namespace Bridge
{
	class TiviAbstraction
	{
		protected RemoteImplementor _implementation;

		public TiviAbstraction(RemoteImplementor implementation)
		{
			this._implementation = implementation;
		}

		public virtual string OperarionF()
		{
			return "Button A1 pressed \n" +
				_implementation.ButtonA1();
		}
	}


	class SamsungTV : TiviAbstraction
	{
		public SamsungTV(RemoteImplementor implementation) : base(implementation)
		{
		}

		public override string OperarionF()
		{
			return "Button A1 pressed on SamsungRemote \n" +
				base._implementation.ButtonA1();
		}
	}

}
