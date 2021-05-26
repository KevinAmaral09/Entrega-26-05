using System;

namespace Elevador
{
    public class JogadorDefesa : Jogador
    {
        public string Aposentar()
        {
            idade = (DateTime.Now.Date.Year) - data;
            if (idade < 40)
            {
                return $"Falta {40 - idade} anos para você se aposentar";
            }
            else
            {
                return "Você já pode se aposentar";
            }
        }
    }
}