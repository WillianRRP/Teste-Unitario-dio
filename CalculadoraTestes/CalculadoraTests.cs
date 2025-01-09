using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;


namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests(){
  _calc = new CalculadoraImp();
    }
       
    

  
    [Fact]
    public void DeveSomar1Com65ERetornar66()
    {
       //Arrange
       int num1 = 1;
       int num2 = 65;

       //Act

       int resultado = _calc.Somar(num1, num2);
     
     //Assert
     Assert.Equal(66, resultado);
    }

     [Fact]
    public void DeveSomar1Com65ERetornar68()
    {
       //Arrange
       int num1 = 3;
       int num2 = 65;

       //Act

       int resultado = _calc.Somar(num1, num2);
     
     //Assert
     Assert.Equal(68, resultado);
    }

    [Fact]
    public void DeveVerificarSe6EHParERetornarVerdadeiro()
    {
      // Arrange
     int numero = 6;
      // act
     bool resultado = _calc.EhPar(numero); 
      // Assert
      Assert.True(resultado);


    }


     [Fact]
    public void DeveVerificarSe5EhImparERetornarVerdadeiro()
        {
            // Arrange
            int numero = 5;

            // Act
            bool resultado = _calc.EhImpar(numero);

            // Assert
            Assert.True(resultado);
        }

     [Theory]
     [InlineData(new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18})]
    public void DeveVerificarSeOsNumerosSaoParesEretornarVerdadeiro(int[] numeros)
        {
           //Act /Assert
           
           
            Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
        }

        public void DeveVerificarSe12NaoEhImparERetornarFalso()
        {
            // Arrange
            int numero = 12;

            // Act
            bool resultado = _calc.EhImpar(numero);

            // Assert
            Assert.False(resultado);
        }
     [Theory]
     [InlineData(new int[] {3, 5, 7, 9, 11, 13, 15, 17, 21})]
    public void DeveVerificarSeOsNumerosSaoImparesEretornarVerdadeiro(int[] numeros)
        {
           //Act /Assert
           
           
            Assert.All(numeros, num => Assert.True(_calc.EhImpar(num)));
        }

   [Theory]
     [InlineData(new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18})]
    public void DeveVerificarSeOsNumerosSaoImparEretornarFalso(int[] numeros)
        {
           //Act /Assert
           
           
            Assert.All(numeros, num => Assert.False(_calc.EhImpar(num)));
        }

     


    
}
