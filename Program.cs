using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

//Si vuole progettare un sistema per la gestione di una biblioteca.
//Gli utenti si possono registrare al sistema, fornendo:

//-cognome,
//-nome,
//-email,
//-password,
//-recapito telefonico,

//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:

//-un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//-titolo,
//-anno,
//-settore(storia, matematica, economia, …),
//-stato(In Prestito, Disponibile),
//-uno scaffale in cui è posizionato,
//- un autore (Nome, Cognome).

//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente,


//effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.

//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

//CLASSI IDENTIFICATE
//UTENTE
Console.WriteLine("Biblioteca 2.0");


Biblioteca biblio = new Biblioteca();




public class Biblioteca
{
    List<Documento> documenti = new List<Documento>(); 


    public Biblioteca()
    {

        documenti.Add(new Libro("ABC","libro", 100));
        documenti.Add(new Libro("ABC","il mare", 200));
        documenti.Add(new Libro("ABC","brutto", 10));

        documenti.Add(new Dvd("ABC","matrix", 120));
        documenti.Add(new Dvd("ABC","matrix 2", 120));
        documenti.Add(new Dvd("ABC","matrix 3", 200));
         
    }

    public List<Documento> RicercaDocumento(string query)
    {
        List<Documento> res = new List<Documento>();

        foreach (Documento doc in documenti)
        {
         
            if (doc.Titolo.Contains(query) || doc.ID.Contains(query))
            {
                res.Add(doc);
            }
        }

        return res;
    }

    public List<Dvd> RicercaFilm(string query)
    {
        List<Dvd> res = new List<Dvd>();

        foreach (Documento doc in documenti)
        {
            if (doc.GetType() == typeof(Dvd) && (doc.Titolo.Contains(query) || doc.ID.Contains(query)))
            {
                res.Add((Dvd)doc);
            }
        }

        return res;
    }
}
