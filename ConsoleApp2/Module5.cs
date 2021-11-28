﻿using System;

class Module5
{

	static string ShowColor(string username)
	{
		Console.WriteLine(username + ", напишите свой любимый цвет на английском с маленькой буквы");
		string color = Console.ReadLine();

		switch (color)
		{
			case "red":
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
				break;

			case "green":
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
				break;
			case "cyan":
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is cyan!");
				break;
			default:
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Red;

				Console.WriteLine("Your color is yellow!");
				break;
		}

		return color;
	}

	static int[] GetArrayFromConsole()
	{
		var result = new int[5];

		for (int i = 0; i < result.Length; i++)
		{
			Console.WriteLine("Введите элемент массива номер {0}", i + 1);
			result[i] = int.Parse(Console.ReadLine());
		}

		return result;
	}

	public static void Task5_1_6(int[] OurArray)
	{

		int temp = 0;

		for (int CurrentIndex = 0; CurrentIndex < OurArray.Length; CurrentIndex++)
		{

			int MaxValueIndex = CurrentIndex, MinValueIndex = CurrentIndex;
			int MinValue = OurArray[CurrentIndex], MaxValue = OurArray[CurrentIndex];

			for (int UpperIndex = (CurrentIndex + 1); UpperIndex < OurArray.Length; UpperIndex++)
			{
				if (OurArray[UpperIndex] > MaxValue)
				{
					MaxValueIndex = UpperIndex;
					MaxValue = OurArray[UpperIndex];
				}

				if (OurArray[UpperIndex] < MinValue)
				{
					MinValueIndex = UpperIndex;
					MinValue = OurArray[UpperIndex];
				}
			}

			temp = OurArray[CurrentIndex];
			OurArray[CurrentIndex] = MinValue;
			OurArray[MinValueIndex] = temp;
			temp = OurArray[(OurArray.Length - 1)];
			OurArray[(OurArray.Length - 1)] = MaxValue;
			OurArray[MaxValueIndex] = temp;

		}

		foreach (int CurrentSymbol in OurArray)
		{
			Console.Write(CurrentSymbol + " ");
		}

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public struct FavoriteColors
	{
		public string First;
		public string Second;
		public string Third;
	}

	public static void Task5_1_1() 
	{

		(string Name, string[] Dishes)User;

		User.Dishes = new string[5];
		Console.WriteLine("Enter your name:");

		User.Name = Console.ReadLine();

		Console.WriteLine("Enter your favorite dishes.");

		for (byte CurrentDish = 1; CurrentDish <= User.Dishes.Length; CurrentDish++) {

			Console.WriteLine("Dish #:" + CurrentDish);
			User.Dishes[(CurrentDish - 1)] = Console.ReadLine();

		}
	
	
	}

	public static void Task5_1_5()
	{

		string[] FavoriteColors = new string[3];
		for(byte ColorNumber = 0; ColorNumber < FavoriteColors.Length; ColorNumber++)
        {
			FavoriteColors[ColorNumber] = ShowColor("");
        }

		foreach(string CurrentColor in FavoriteColors)
        {
			Console.WriteLine(CurrentColor);
        }
	}

	public static void Task5_2_2()
	{

		int UserQuantity = 3;

		(string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, FavoriteColors FavColors) User;

		Console.WriteLine("/--------------------------------------------/");
		for (byte CurrentUser = 1; CurrentUser <= UserQuantity; CurrentUser++)
		{

			Console.WriteLine("Input info of user #{0}", CurrentUser);
			Console.WriteLine("/--------------------------------------------/");

			Console.WriteLine("Enter name:");
			User.Name = Console.ReadLine();

			Console.WriteLine("Enter last name:");
			User.LastName = Console.ReadLine();

			Console.WriteLine("Enter login:");
			User.Login = Console.ReadLine();

			User.LoginLength = User.Login.Length;

			Console.WriteLine("Do you have any pets? Yes/No:");
			string UserAnswer = Console.ReadLine();

			if (UserAnswer == "Yes")
			{
				User.HasPet = true;
			}
			else
			{
				User.HasPet = false;
			}

			Console.WriteLine("Enter your age:");
			User.Age = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter your favorite colors.");
			Console.WriteLine("Color 1");
			User.FavColors.First = ShowColor(User.Name);

			Console.WriteLine("Color 2");
			User.FavColors.Second = ShowColor(User.Name);

			Console.WriteLine("Color 3");
			User.FavColors.Third = ShowColor(User.Name);

			Console.WriteLine("/--------------------------------------------/");

		}

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	
}