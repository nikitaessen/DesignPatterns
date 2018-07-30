using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
	public class VictorianFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			throw new System.NotImplementedException();
		}

		public ISofa CreateSofa()
		{
			throw new System.NotImplementedException();
		}

		public ITable CreateTable()
		{
			throw new System.NotImplementedException();
		}
	}
}
