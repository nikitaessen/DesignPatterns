using AbstractFactory.Interfaces;

namespace AbstractFactory.Chairs
{
	public class VictorianChair : IChair
	{
		public bool HasLegs()
		{
			throw new System.NotImplementedException();
		}

		public void SitOn()
		{
			throw new System.NotImplementedException();
		}
	}
}
