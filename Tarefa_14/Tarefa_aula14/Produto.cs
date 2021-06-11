namespace Tarefa_aula14
{
    public abstract class Produto : IImprimivel
    {

        protected Fornec _fornec;
        protected string _nome;
        protected double _preco;
        
        public double Preco
        {
            get { return this._preco;}
        }
        
        public string Nome
        {
            get { return this._nome; }
        }
        
        public Fornec Fornec
        {
            get { return this._fornec; }
        }
        public abstract double CalculaValorTotal();
        public abstract void Imprimir();
        
    }
}