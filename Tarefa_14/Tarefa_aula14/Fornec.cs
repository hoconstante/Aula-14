using System;

namespace Tarefa_aula14
{
	public class Fornec:IImprimivel
	{
		private string _name;
		private string _address;
		private string _codid;
		private string _contact;

		public string Name
        {
			get { return this._name; }
        }
		public string Address
		{
			get { return this._address; }
		}
		public string CodId
		{
			get { return this._codid; }
		}
		public string Contact
		{
			get { return this._contact; }
		}

		public Fornec (string name, string address, string codid, string contact)
        {
			this._name = name;
			this._address = address;
			this._codid = codid;
			this._contact = contact;
        }

		public void Imprimir()
        {
			Console.WriteLine("Fornecedor:\t"+ this.Name);
			Console.WriteLine("endereco:\t"+ this.Address);
			Console.WriteLine("cnpj:\t"+ this.CodId);
			Console.WriteLine("contato:\t"+ this.Contact);
		}
	}
}