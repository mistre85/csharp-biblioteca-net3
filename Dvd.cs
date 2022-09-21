public class Dvd : Documento
{

    public string Seriale
    {
        get
        {
            return base.ID;
        }

        set
        {
  
            base.ID = value;
          
        }
    }

    int durata;

    public Dvd(string id,string titolo,int durata) : base(id,titolo)
    {
        this.durata = durata;
    }
}
