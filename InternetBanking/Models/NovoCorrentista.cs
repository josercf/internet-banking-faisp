using System;

namespace InternetBanking.Models
{
    public class NovoCorrentista
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }



        public bool ValidarIdade()
        {
           TimeSpan tempo = (DateTime.Now - DataNascimento);
            var idade = tempo.TotalDays / 365;


            return idade >= 16;
        }
    }
}
