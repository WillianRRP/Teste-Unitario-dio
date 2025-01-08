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
}
