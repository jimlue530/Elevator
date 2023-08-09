namespace ElevatorTest;
using Xunit;
using ElevatorSimulator;

public class ElevatorTests
{
    [Fact]
    public void TestElevatorMove()
    {
        // Arrange
        Elevator e = new Elevator("TestElevator", 1);

        // Act
        e.Move(5);

        // Assert
        Assert.Equal(5, e.current_floor);
    }
}