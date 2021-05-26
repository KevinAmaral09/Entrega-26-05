using System;

namespace Elevador
{
    public class JogadorAtaque : Jogador
    {
        public string Aposentar()
        {
            idade = (DateTime.Now.Date.Year) - data;
            if (idade < 35)
            {
                return $"Falta {35 - idade} anos para você se aposentar";
            }
            else
            {
                return "Você já pode se aposentar";
            }
        }
    }
}