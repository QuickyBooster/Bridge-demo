
namespace Bridge
{
	public interface RemoteImplementor
	{
		string ButtonA1();
	}


	class SamsungRemote : RemoteImplementor
	{
		public string ButtonA1()
		{
			return "Increase the VOLUME \n";
		}
	}

	class LGRemote : RemoteImplementor
	{
		public string ButtonA1()
		{
			return "Switch to NETFLIX \n";
		}
	}
}
