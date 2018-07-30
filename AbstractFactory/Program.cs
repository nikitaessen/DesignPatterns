using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			IFurnitureFactory factory = new DesignFactory();
			factory.CreateChair();
			factory.CreateSofa();
			factory.CreateTable();

			factory = new ModernFactory();
			factory.CreateSofa();
			factory.CreateChair();
			factory.CreateTable();

			Console.ReadLine();
		}
	}
}
