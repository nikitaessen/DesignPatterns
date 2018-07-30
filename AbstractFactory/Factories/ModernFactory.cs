using AbstractFactory.Chairs;
using AbstractFactory.Interfaces;
using AbstractFactory.Sofas;
using AbstractFactory.Tables;

namespace AbstractFactory.Factories
{
	public class ModernFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			return new ModernChair();
		}

		public ISofa CreateSofa()
		{
			return new ModernSofa();
		}

		public ITable CreateTable()
		{
			return new ModernTable();
		}
	}
}
