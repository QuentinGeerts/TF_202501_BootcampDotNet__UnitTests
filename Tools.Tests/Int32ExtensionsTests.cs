namespace Tools.Tests;

public class Int32ExtensionsTests
{
    [Fact]
    public void IsPrime_ShouldReturnTrue_WhenValueIsFive()
    {
        // Arrange: Mise en place du contexte
        int value = 5;

        // Act: Exécution de la méthode
        bool result = value.IsPrime();

        // Assert: Comparaison du résultat obtenu par rapport à celui attendu
        Assert.True(result);
    }

    [Fact]
    public void IsPrime_ShouldReturnTrue_WhenValueIsTwo()
    {
        // Arrange: Mise en place du contexte
        int value = 2;

        // Act: Exécution de la méthode
        bool result = value.IsPrime();

        // Assert: Comparaison du résultat obtenu par rapport à celui attendu
        Assert.True(result);
    }

    [Theory]
    [InlineData(2, 4, 5)]
    public void IsPrime2_ShouldReturnTrue_WhenValueIsPrime(int a, int b, int c)
    {
        // Arrange: Mise en place du contexte => dans les paramètres

        // Act: Exécution de la méthode
        bool result1 = a.IsPrime();
        bool result2 = b.IsPrime();
        bool result3 = c.IsPrime();

        // Assert: Comparaison du résultat obtenu par rapport à celui attendu
        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(6)]
    public void IsPrime_ShouldReturnTrue_WhenValueIsPrime(int value)
    {
        // Arrange: Mise en place du contexte => dans les paramètres

        // Act: Exécution de la méthode
        bool result1 = value.IsPrime();

        // Assert: Comparaison du résultat obtenu par rapport à celui attendu
        Assert.True(result1);
    }

    [Fact]
    public void IsPrime_ShouldReturnFalse_WhenValueIsEven()
    {
        // Arrange
        int value = 42;

        // Act
        bool result = value.IsPrime();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPrime_ShouldThrowArgumentException_WhenValueIsLess2()
    {
        // Arrange
        int value = -1;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => value.IsPrime());
    }

    [Theory]
    [InlineData(1, "La valeur 1 ne peut pas être inférieure à 2.")]
    [InlineData(-50, "La valeur -50 ne peut pas être inférieure à 2.")]
    public void IsPrime_ShouldThrowArgumentExceptionWithAMessage_WhenValueIsLess2(int value, string expectedMessage)
    {
        // Act
        ArgumentException ex = Assert.Throws<ArgumentException>(() => value.IsPrime());

        // Assert
        Assert.Equal(expectedMessage, ex.Message);
    }
}