using AbstractFactory.Chairs;
using AbstractFactory.Interfaces;
using AbstractFactory.Sofas;
using AbstractFactory.Tables;

namespace AbstractFactory.Factories
{
	public class DesignFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			return new DesignedChair();
		}

		public ISofa CreateSofa()
		{
			return new DesignedSofa();
		}

		public ITable CreateTable()
		{
			return new DesignedTable();
		}
	}
}
