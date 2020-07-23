
using System;

namespace XGame.Domain.Entities
{
    public class JogoPlataforma
    {
        public GUID Id
        {get; set;}

        public Jogo Jogo
        {get; set;}

        public Plataforma Plataforma
        {get; set;}        

        public Datetime DataLancamento
        {get; set;}

    }
}