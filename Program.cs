/*
 * This program is based of AQQA's EasyCryptApp
 * The Encryption code is still the same. But this time in CUI
 * 
 * Original program: https://github.com/AMIDIBOSS/EasyCryptApp
 */ 

// TODO: Use command-line arguments instead of program CUI
// Will Be more efficient

using System;

namespace EasyCryptConsole
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("What do you want to do");
			Console.WriteLine();
			Console.WriteLine("1 - Encrypt");
			Console.WriteLine("2 - Decrypt");
			Console.WriteLine();
			
			string operation = Console.ReadLine();
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("Enter the message: ");
			Console.ResetColor();
			string message = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("Enter the encryption key: ");
			Console.ResetColor();
			string key = Console.ReadLine();
			
			Console.WriteLine();
			
			if (operation == "1") { 
				
				Console.WriteLine("Output = " + Encryptor.Encrypt(message, key));
			
			} else if (operation == "2") {
			
				Console.WriteLine("Output = " + Encryptor.Decrypt(message, key));
			
			} else {
			
				Console.WriteLine("Invalid Operation");
				
			}
			
			Console.ReadKey(true);
		}
	}
}