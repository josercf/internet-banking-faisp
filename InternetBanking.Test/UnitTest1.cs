using InternetBanking.Models;
using System;
using Xunit;

namespace InternetBanking.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Idade_maior_que_16()
        {
            var correntista = new NovoCorrentista();
            correntista.DataNascimento = new System.DateTime(2030, 04, 01);


            var dataValida = correntista.ValidarIdade();

            Assert.True(dataValida);
        }


        [Fact]
        public void Idade_Igual_A_16()
        {
            var correntista = new NovoCorrentista();
            correntista.DataNascimento = new System.DateTime(2030, 04, 01);


            var dataValida = correntista.ValidarIdade();

            Assert.True(dataValida);
        }

        [Fact]
        public void Idade_Menor_que_16()
        {
            var correntista = new NovoCorrentista();
            correntista.DataNascimento = new System.DateTime(2010, 04, 01);


            var dataValida = correntista.ValidarIdade();

            Assert.False(dataValida);
        }
    }
}
