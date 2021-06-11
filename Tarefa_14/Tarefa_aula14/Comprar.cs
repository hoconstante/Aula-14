using System;
using System.Collections.Generic;

namespace Tarefa_aula14
{
	public class Comprar:IImprimivel
	{

        protected Guardado _guardado;
        protected Cliente _cliente;
        protected Carrinho _precompra;

		public Guardado Guardado
        {
			get { return this._guardado; }
			set
            {
				_guardado = value;
            }
        }

        public Cliente Cliente
        {
            get { return this._cliente; }
        }

        public Carrinho Carrinho
        {
            get { return this._precompra; }
        }

        public Comprar (Cliente cliente, Carrinho precompra, Guardado guardado)
        {
            this._precompra = precompra;
            this._cliente = cliente;
            this._guardado = guardado;
		}

        public void Imprimir()
        {
            foreach(var itens in _guardado.Catlog)
            {
                Cliente.Imprimir();
                Carrinho.ImprimirCarrinho();
            }
        }

    }
}