using System;

namespace Assignment1
{
	/// <summary>
	/// Class that completes assignment 1. Takes user input of angle and speed to determine apex and horizontal distance travelled.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// Entry point for assignment 1 console application.
		/// </summary>
		/// <param name="args">The command line arguments. We do nothing with these.</param>
		public static void Main(string[] args)
		{
			Console.WriteLine("Greetings! This application will calculate the maximum height of the shell and the distance it will travel along the ground.");

			Console.WriteLine("Please input the initial angle in degrees:");

			// Convert the input straight into radians
			var theta = float.Parse(Console.ReadLine()) * Math.PI / 180;

			Console.WriteLine("Please input the initial speed in m/s:");
			var speed = float.Parse(Console.ReadLine());

			var vox = speed * (float)Math.Cos(theta);
			var voy = speed * (float)Math.Sin(theta);

			var g = 9.8;
			var time = voy / g;
			var heightAtApex = voy * voy / (2 * g);

			Console.WriteLine("Height at the apex equals {0:0.000}", heightAtApex);

			var dx = vox * 2 * time;

			Console.WriteLine("Distance travelled horizontally equals {0:0.000}", dx);
		}
	}
}
