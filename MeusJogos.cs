
using System;

namespace XGame.Domain.Entities
{
    public class MeuJogo
    {
        public GUID Id
        {get; set;}

        public JogoPlataForma JogoPlataforma
        {get; set;} 

        public bool JogoDesejavel
        {get; set;}

        public bool TrocoJogo
        {get; set;}

        public bool VendoJogo
        {get; set;}

        public Datetime DataAcaoJogoDesejavel
        {get; set;}


    }
}