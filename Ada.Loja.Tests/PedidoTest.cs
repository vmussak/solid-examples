namespace Ada.Loja.Tests
{
    public class PedidoTest
    {
        [Fact]
        public void Pedido_Deve_Calcular_ValorSubTotal_Corretamente()
        {
            var pedido = new Pedido();
            pedido.AdicionarItem(new Cerveja("Heineken", 15)); //0.2
            pedido.AdicionarItem(new Suco("Prats", 20)); //0.1
            pedido.AdicionarItem(new Agua("Cristal", 5)); //0

            var total = pedido.CalculaValorSubtotal();

            Assert.Equal(40, total);
        }

        [Fact]
        public void Pedido_Deve_Calcular_ValorTaxas_Corretamente()
        {
            var pedido = new Pedido();
            var data = new DateTime(2018, 04, 1);
            pedido.AdicionarItem(new Cerveja("Heineken", 15)); //0.2
            pedido.AdicionarItem(new Suco("Prats", 20)); //0.1
            pedido.AdicionarItem(new Agua("Cristal", 5)); //0
            pedido.AdicionarItem(new Destilado("Vodka", 10)); //0.5

            var total = pedido.CalculaValorTaxas(data);

            Assert.Equal(10, total);
        }

        [Fact]
        public void Pedido_Deve_Calcular_ValorTaxas_EmDezembro_Corretamente()
        {
            var pedido = new Pedido();
            var data = new DateTime(2018, 12, 1);
            pedido.AdicionarItem(new Cerveja("Heineken", 15)); //0.2
            pedido.AdicionarItem(new Suco("Prats", 20)); //0.1
            pedido.AdicionarItem(new Agua("Cristal", 5)); //0
            pedido.AdicionarItem(new Destilado("Vodka", 10)); //0.1

            var total = pedido.CalculaValorTaxas(data);

            Assert.Equal(6, total);
        }

        [Fact]
        public void Pedido_Deve_Calcular_ValorTotal_Corretamente()
        {
            var pedido = new Pedido();
            var data = new DateTime(2018, 04, 1);
            pedido.AdicionarItem(new Cerveja("Heineken", 15)); //0.2
            pedido.AdicionarItem(new Suco("Prats", 20)); //0.1
            pedido.AdicionarItem(new Agua("Cristal", 5)); //0

            var total = pedido.CalculaValorTotal(data);

            Assert.Equal(45, total);
        }
    }
}