/**

Maximum Occurrence

Given a string text. 
Write a function that returns the character with the highest frequency. 
If more than 1 character has the same highest frequency, return all those characters as a comma separated string.
If there is no repetition in characters, return "No Repetition".

Example

MaxOccur("Computer Science") ➞ "e"

MaxOccur("Edabit") ➞ "No Repetition"

MaxOccur("system admin") ➞ "m, s"

MaxOccur("the quick brown fox jumps over the lazy dog") ➞ " "

**/
					
public class Program
{
	static char mostRepeatingChar(string s)
	{
		int[] count = new int[256];
		int max = 0;
		char result = char.MinValue;
		
		foreach(char c in  s)
			if(++count[c] > max)
			{
				max = count[c];
				result = c;
			}
	
		return result;
	}
	public static void Main()
	{
		string text = System.Console.ReadLine();
		System.Console.WriteLine("Maximum occuring character is '{0}'", mostRepeatingChar(text));
	}
}