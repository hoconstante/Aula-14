using System;
using System.Collections.Generic;

namespace Tarefa_aula14
{
	public class Guardado
	{
		protected Dictionary<Produto, int> _catlog = new Dictionary<Produto, int>();

        public Dictionary<Produto, int> Catlog
        {
            get { return this._catlog; }

        }

        public void Adicionar(Produto item, int quant)
        {
            if (this._catlog.ContainsKey(item))
                this._catlog[item] = this._catlog[item] + quant;
            else
                this._catlog[item] = quant;
        }

        public void Adicionar(Produto item)
        {
            this.Adicionar(item, 1);
        }

        public void Adicionar(List<Produto> itens)
        {
            foreach (var item in itens)
            {
                this.Adicionar(item);
            }
        }

        public void Adicionar(Dictionary<Produto, int> itens)
        {
            foreach (KeyValuePair<Produto, int> parOrdenado in itens)
            {
                this.Adicionar(parOrdenado.Key, parOrdenado.Value);
            }
        }

        public void AtualizarEstoque(Carrinho precompra)
        {
            Dictionary<Produto, int> tempoguardado = new Dictionary<Produto, int>();
            foreach (var item in precompra.Itens.Keys)
            {
                if (this._catlog.TryGetValue(item, out int quanto))
                {
                    quanto -= 1;
                    tempoguardado.Add(item, quanto);
                }
                else
                {
                    tempoguardado.Add(item, quanto);
                }
            }
            this._catlog.Clear();
            foreach(var item in tempoguardado)
            {
                _catlog.Add(item.Key, item.Value);
            }
           
        }
    }


}