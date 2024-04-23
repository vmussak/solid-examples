namespace Ada.Loja
{
    public abstract class Item
    {
        public Item(string categoria, string descricao, decimal valor)
        {
            Categoria = categoria;
            Descricao = descricao;
            Valor = valor;
        }

        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; } 
    }
}