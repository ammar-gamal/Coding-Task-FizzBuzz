using System.Text;

namespace FizzBuzz {
  public class FizzBuzzDetector {
    private const int _fizzDivisor = 3;
    private const int _buzzDivisor = 5;
    /// <summary>
    /// Scans <paramref name="input"/> word by word, replacing every word whose it's 
    /// position is divisible by 3 with "Fizz", divisible by 5 with "Buzz",
    /// and divisible by 15 with "FizzBuzz. ". 
    /// </summary>    
    /// <remarks>
    /// Word boundaries are determined by whitespace characters or the end of the string.
    /// </remarks>
    /// <param name="input">The input string to process.</param>
    /// <returns>A <see cref="FizzBuzzResult"/> 
    /// containing the output string and replacements count.
    /// </returns>
    public FizzBuzzResult GetOverlappings(string input) {
      var result = new StringBuilder();
      int wordsCount = 0;
      int replacementsCount = 0;
      int idx = 0;
      while (idx < input.Length) {
        if (!char.IsLetterOrDigit(input[idx])) {
          result.Append(input[idx]);
          idx++;
          continue;
        }

        wordsCount++;
        var currentWord = new StringBuilder();
        while (idx < input.Length && input[idx] != ' ') {
          // Iterating over sepcific word until it's end 
          // Word boundaries are determined by whitespace characters or the end of the string.
          currentWord.Append(input[idx]);
          idx++;
        }

        bool isFizz = wordsCount % _fizzDivisor == 0;
        bool isBuzz = wordsCount % _buzzDivisor == 0;

        if (isFizz && isBuzz) {
          // because the 15th is divisible by 3 and 5
          replacementsCount++;
          result.Append("FizzBuzz");
        } else if (isFizz) {
          replacementsCount++;
          result.Append("Fizz");
        } else if (isBuzz) {
          replacementsCount++;
          result.Append("Buzz");
        } else {
          result.Append(currentWord);
        }
      }

      return new FizzBuzzResult {
        Output = result.ToString(),
        Count = replacementsCount
      };
    }
  }
}