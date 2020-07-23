using System;

namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Guid IdJogador {get; set;}

        public Nome NomeJogador { get; set; }

        public Email Email {get; set;}

        public string Senha {get; set;}    
    }
}
