using System.Text;
namespace FizzBuzz;

public class FizzBuzzDetector {
  /// <summary>
  /// Replaces every 3th word with Fizz, every 5th with Buzz and every 15th with FizzBuzz and counts the total replacements.
  /// </summary>
  /// <param name="input">The input string to process.</param>
  /// <returns>A <see cref="FizzBuzzResult"/> containing the output string and replacments count.</returns>
  public FizzBuzzResult GetOverlappings(string input) {
    StringBuilder result = new("");
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
      StringBuilder currentWord = new("");
      while (idx < input.Length && input[idx] != ' ') {//Iterating over sepcific word until it's end
        currentWord.Append(input[idx]);
        idx++;
      }

      bool isFizz = wordsCount % 3 == 0;
      bool isBuzz = wordsCount % 5 == 0;

      if (isFizz && isBuzz) {//because the 15th is divisble by 3 and 5
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
