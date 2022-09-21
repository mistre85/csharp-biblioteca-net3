using System.Reflection.Metadata;

public class Documento
{

    public string ID { get; protected set; }

    public string Titolo { get;}
    string anno;
    string settore;
    string stato;
    string scaffale;

    Autore autore;

    public Documento(string id,string titolo)
    {
        this.ID = id;
        this.Titolo = titolo;
    }

}
