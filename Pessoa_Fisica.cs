

using AtividadeLegal;

class Pessoa_Fisica : Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }

        public override void Pagar_Imposto(float val_pag)
        {
            base.Pagar_Imposto(val_pag);
            this.valor_imposto = val_pag * 10/100; 
            this.total = val_pag + this.valor_imposto;
        }

    internal string GetValor()
    {
        throw new NotImplementedException();
    }
}