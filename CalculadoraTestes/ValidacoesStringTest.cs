using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTest
{

    private ValidacoesString _Validacoes;

    public ValidacoesStringTest()
    {
   _Validacoes= new ValidacoesString();
    }
       
    

  
    [Fact]
    public void DeveContar4CaracteresEmAobaERetornar4()
    {
       //Arrange
       string texto = "Aoba";


       //Act

       int resultado = _Validacoes.ContarCaracteres(texto);
     
     //Assert
     Assert.Equal(4, resultado);
    }
        
    }
}
