
namespace AprendendoSolid
{
    internal class TesteModeloAnemico
    {
        public int ItemId { get; private set; }
        public int PedidoId { get; private set; }

        private string _itemNome;
        public string ItemNome
        {
            get => this._itemNome;

            private set
            {
                this._itemNome = (value.Length > 100) ?
                    throw new ArgumentOutOfRangeException(nameof(ItemNome),
                    "O nome do item não pode exceder 100 caracteres") : value;
            }
        }

        private decimal _itemPreco;
        public decimal ItemPreco
        {
            get => this._itemPreco;          
            private set
            {
                this._itemPreco = (value <= 0) ?
                    throw new ArgumentOutOfRangeException(nameof(ItemPreco),
                    "o preço deve ser maior que 0") : value;
            }
        }




        public TesteModeloAnemico(int itemId, int pedidoId)
        {
            if (itemId <= 0)
            {
                throw new ArgumentException("O item deve ser informado com um valor maior que 0");
            }

            if (pedidoId <= 0)
            {
                throw new ArgumentException("O pedido deve ser informado com um valor maior que 0");
            }

            ItemId = itemId;
            PedidoId = pedidoId;

        }



    }
}
