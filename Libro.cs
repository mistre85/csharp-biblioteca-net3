public class Libro : Documento {
   
    public string ISBN { 
        get {
            return base.ID;
        }

        set
        {
            //if di controloo
            base.ID = value;
        }
    }
    public int NumeroPagine { get;  }

    public Libro(string id, string titolo,int numeroPagine) : base(id, titolo)
    {
       
        this.NumeroPagine = numeroPagine;
    }
}
