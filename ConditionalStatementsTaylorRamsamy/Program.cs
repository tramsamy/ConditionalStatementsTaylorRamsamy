using System;

namespace ConditionalStatementsTaylorRamsamy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("Please write down the score you believe you will recieve in ISM 4300. Please enter this score as a number out of 100. Do not include the % sign.");
			String ScoreInput;
			ScoreInput = Console.ReadLine();
			int Score;
			Score = Convert.ToInt32(ScoreInput);
			String Grade = "";
			if (Score >= 98) {

				Grade = "A+";
			}

			else if (Score >= 92 && Score <= 97) {

				Grade = "A";
			}

			else if(Score >= 90 && Score <= 91){

				Grade = "A-";
			}

			else if(Score >= 88 && Score <= 89)
			{

				Grade = "B+";
			}

			else if(Score >= 82 && Score <= 87)
			{

				Grade = "B";
			}

			else if (Score >= 80 && Score <= 81)
			{

				Grade = "B-";
			}

			else if (Score >= 78 && Score <= 79)
			{

				Grade = "C+";
			}

			else if (Score >= 72 && Score <= 77)
			{

				Grade = "C";
			}

			else if (Score >= 70 && Score <= 71)
			{

				Grade = "C-";
			}

			else if (Score >= 68 && Score <= 69)
			{

				Grade = "D+";
			}

			else if (Score >= 62 && Score <= 67)
			{

				Grade = "D";
			}

			else if (Score >= 60 && Score <= 61)
			{

				Grade = "D-";
			}

			else if (Score <= 59)
			{

				Grade = "F";
			}
			Console.WriteLine("According to the syllabus, based on the score that you have inputted, your grade in ISM 4300 will be: ");
			Console.WriteLine(Grade);

		}
	}
}
