using QuickBuy.Dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento  FormaPagamento { get; set; }


        /// <summary>
        /// Pedidos pode ter pelo menos um item de pedido ou
        /// muitos itens de pedidos
        /// </summary>
        public ICollection<ItemPedido>ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMenssagensValidacao();

            if (!ItensPedido.Any())
                AdicionaCritica("Erro - pedido não pode ficar sem iten de pedido");
               

            if (string.IsNullOrEmpty(CEP))
                AdicionaCritica("Erro - CEP deve estar preenchido");

            if (FormaPagamentoId == 0)
                AdicionaCritica("Erro - Não foi informado a forma de Pagamento");

        }
    }
}
