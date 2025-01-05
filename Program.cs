using System;
using System.Diagnostics;

namespace gta6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
					UseShellExecute = true
				});

				Console.WriteLine("Ссылка успешно открыта.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка: {ex.Message}");
			}

			Environment.Exit(0);
		}
	}
}