namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Find_The_Max_Value_When_The_Max_Method_Is_Called(){
      Calculator calculator = new Calculator();
      Assert.Equal(50, calculator.Max(9, 50));
    }

    [Fact]
    public void Should_Round_The_Double_Value_To_The_Third_Decimal_Point_Position_When_The_Round_Method_Is_Called(){
      Calculator calculator = new Calculator();
      Assert.Equal(12.235, calculator.Round(12.23456789));
    }
}