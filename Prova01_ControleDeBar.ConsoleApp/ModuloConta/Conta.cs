﻿using Prova01_ControleDeBar.ConsoleApp.ModuloGarcom;
using Prova01_ControleDeBar.ConsoleApp.ModuloMesa;
using Prova01_ControleDeBar.ConsoleApp.ModuloPedido;

namespace Prova01_ControleDeBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Mesa mesa;
        public Garcom garcom;
        public List<Pedido> pedidos = new();
        public Pedido pedido;
        public bool estado = true;
        public double valorTotal;
    }
}
