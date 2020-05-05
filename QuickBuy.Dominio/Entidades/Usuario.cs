using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public string SobreNome { get; set; }

        /// <summary>
        /// Usuario pode ter nenhum ou muitos pedidos 
        /// </summary>
        public ICollection<Pedido>Pedidos { get; set; }



    }
}
