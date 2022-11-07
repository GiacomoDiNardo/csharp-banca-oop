
// See https://aka.ms/new-console-template for more information



//La banca è caratterizzata da

//    un nome
//    un insieme di clienti (una lista)
//    un insieme di prestiti concessi ai clienti (una lista)

//Per la banca deve essere possibile:

//    aggiungere, modificare e ricercare un cliente.
//    aggiungere un prestito.
//    effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//    sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//    sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

public class Banca
{
    public string Nome { get; set; }
    List<Cliente> Clienti { get; set; }
    List<Prestito> Prestiti { get; set; }

    public Banca (string nome)
    {
        Nome = nome;
        Clienti = new List<Cliente>();
        Prestiti = new List<Prestito>();
    }

    public bool AggiungiCliente (string nome, string cognome, string codiceFiscale, int stipendio)
    {
        if (nome == null || nome == "" || cognome == null || cognome == "" || codiceFiscale == null || codiceFiscale == "" || stipendio < 0)
        {
            return false;
        }

        Cliente esistente = RicercaCliente(codiceFiscale);

        
        if (esistente != null)
            return false;

        Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
        Clienti.Add(cliente);

        return true;
    }

    public Cliente RicercaCliente(string codiceFiscale)
    {
        foreach (Cliente cliente in Clienti)
        {
            if (cliente.CodiceFiscale == codiceFiscale)
            {
                return cliente;
            }
        }

        return null;
    }

    public Cliente ModificaCliente(Cliente cliente)
    {

        Console.WriteLine("Inserisci nuovo nome:");
        string nuovoNome = Console.ReadLine();
        if (nuovoNome != null && nuovoNome != "" && nuovoNome != cliente.Nome)
        {
            cliente.Nome = nuovoNome;
        }

        Console.WriteLine("Inserisci nuovo cognome:");
        string nuovoCognome = Console.ReadLine();
        if (nuovoCognome != null && nuovoCognome != "" && nuovoCognome != cliente.Cognome)
        {
            cliente.Cognome = nuovoCognome;
        }

        Console.WriteLine("Inserisci nuovo codice fiscale:");
        string nuovoCodiceFiscale = Console.ReadLine();
        if (nuovoCodiceFiscale != null && nuovoCodiceFiscale != "" && nuovoCodiceFiscale != cliente.CodiceFiscale)
        {
            cliente.CodiceFiscale = nuovoCodiceFiscale;
        }

        Console.WriteLine("Inserisci nuovo stipendio:");
        int nuovoStipendio = Convert.ToInt32(Console.ReadLine());
        if (nuovoStipendio != 0 && nuovoStipendio != cliente.Stipendio)
        {
            cliente.Stipendio = nuovoStipendio;
        }else
        {
            Console.WriteLine("error: stipendio non valido");
        }

        return cliente;
    }

    public List<Prestito> RicercaPrestito (string codiceFiscale)
    {
        List<Prestito> trovati = new List<Prestito>();

        foreach (Prestito prestito in Prestiti)
        {
            if (prestito.Intestatario.CodiceFiscale == codiceFiscale)
            {
                trovati.Add(prestito);
            }
        }

        return trovati;
    }

    public bool AggiungerePrestito(int id, int ammontare, int rata, string codiceFiscale)
    {
        Cliente cliente = RicercaCliente(codiceFiscale);

        if (ammontare == 0 || rata == 0 || codiceFiscale == "" || codiceFiscale == null || cliente == null || cliente.CodiceFiscale != codiceFiscale)
        {
            return false;
        }

        DateOnly dataInizio = DateOnly.FromDateTime(DateTime.Now);
        DateOnly dataFine = dataInizio.AddMonths(12);

        Prestito prestito = new Prestito(id, ammontare, rata, dataInizio, dataFine, cliente);
        Prestiti.Add(prestito);

        return true;

    }

    public int TotPrestiti(string codiceFiscale)
    {
        Cliente cliente = RicercaCliente(codiceFiscale);
        int conto = 0;
        foreach (Prestito prestito in Prestiti)
        {
            if (prestito.Intestatario.CodiceFiscale == codiceFiscale)
            {
                conto++;
            }
        }
        return conto;
    }

    public int RateDaPagare(string codiceFiscale)
    {
        Cliente cliente = RicercaCliente(codiceFiscale);
        int conto = 0;

        foreach (Prestito prestito in Prestiti)
        {
            int daPagare = prestito.Ammontare / prestito.Rata;
            conto += daPagare;
        }

        return conto;
    }
}