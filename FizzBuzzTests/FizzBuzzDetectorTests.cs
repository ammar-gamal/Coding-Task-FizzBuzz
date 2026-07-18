using FizzBuzz;

namespace FizzBuzzTests;

public class FizzBuzzDetectorTests {
  private readonly FizzBuzzDetector _sut;
  public FizzBuzzDetectorTests() {
    _sut = new();
  }
  [Fact]
  public void GetOverlappings_TestCase1_ShouldReturnExepctedOutputAndCount() {
    //Arrange
    const string input =
      "Mary had a little lamb " +
      "Little lamb, little lamb " +
      "Mary had a little lamb " +
      "It's fleece was white as snow";


    //Act
    var actual = _sut.GetOverlappings(input);

    //Assert
    const string expectedOutput =
      "Mary had Fizz little Buzz " +
      "Fizz lamb, little Fizz " +
      "Buzz had Fizz little lamb " +
      "FizzBuzz fleece was Fizz as Buzz";
    int expectedCount = 9;
    Assert.Equal(expectedOutput, actual.Output);
    Assert.Equal(expectedCount, actual.Count);
  }

  [Fact]
  public void GetOverlappings_TestCase2_ShouldReturnExepctedOutputAndCount() {
    //Arrange
    const string input = "On!e Two T^hree Four Five Six Seven Eight Nine Ten";

    //Act
    var actual = _sut.GetOverlappings(input);

    //Assert
    const string expectedOutput = "On!e Two Fizz Four Buzz Fizz Seven Eight Fizz Buzz";
    int expectedCount = 5;
    Assert.Equal(expectedOutput, actual.Output);
    Assert.Equal(expectedCount, actual.Count);
  }
  [Fact]
  public void GetOverlappings_TestCase3_ShouldReturnExepctedOutputAndCount() {
    //Arrange
    const string input = "Hello";

    //Act
    var actual = _sut.GetOverlappings(input);

    //Assert
    const string expectedOutput = "Hello";
    int expectedCount = 0;
    Assert.Equal(expectedOutput, actual.Output);
    Assert.Equal(expectedCount, actual.Count);
  }
  [Fact]
  public void GetOverlappings_TestCase4_ShouldReturnExepctedOutputAndCount() {
    //Arrange 
    const string input = "One    Two   Three     Four   Five   Six";

    //Act
    var actual = _sut.GetOverlappings(input);

    //Assert
    const string expectedOutput = "One    Two   Fizz     Four   Buzz   Fizz";
    int expectedCount = 3;
    Assert.Equal(expectedOutput, actual.Output);
    Assert.Equal(expectedCount, actual.Count);
  }

  [Fact]
  public void GetOverlappings_TestCase5_ShouldReturnExepctedOutputAndCount() {
    //Arrange
    const string input = "One Two Three";

    //Act
    var actual = _sut.GetOverlappings(input);

    //Assert
    const string expectedOutput = "One Two Fizz";
    int expectedCount = 1;
    Assert.Equal(expectedOutput, actual.Output);
    Assert.Equal(expectedCount, actual.Count);
  }
  [Fact]
  public void GetOverlappings_TestCase6_ShouldReturnExepctedOutputAndCount() {
    //Arrange
    const string input = "One Two Three Four Five";

    //Act
    var actual = _sut.GetOverlappings(input);

    //Assert
    const string expectedOutput = "One Two Fizz Four Buzz";
    int expectedCount = 2;
    Assert.Equal(expectedOutput, actual.Output);
    Assert.Equal(expectedCount, actual.Count);
  }

  [Fact]
  public void GetOverlappings_TestCase7_ShouldReturnExepctedOutputAndCount() {
    //Arrange
    const string input = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15";

    //Act
    var actual = _sut.GetOverlappings(input);

    //Assert
    const string expectedOutput = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
    int expectedCount = 7;
    Assert.Equal(expectedOutput, actual.Output);
    Assert.Equal(expectedCount, actual.Count);
  }
}
