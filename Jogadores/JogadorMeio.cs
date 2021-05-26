using System;

namespace Elevador
{
    public class JogadorMeio : Jogador
    {
        public string Aposentar()
        {
            idade = (DateTime.Now.Date.Year) - data;
            if (idade < 38)
            {
                return $"Falta {38 - idade} anos para você se aposentar";
            }
            else
            {
                return "Você já pode se aposentar";
            }
        }
    }
}