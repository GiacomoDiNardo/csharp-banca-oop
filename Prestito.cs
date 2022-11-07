// See https://aka.ms/new-console-template for more information


//I prestiti sono caratterizzati da

//    ID
//    intestatario del prestito (il cliente),
//    un ammontare,
//    una rata,
//    una data inizio,
//    una data fine.

public class Prestito
{
    public static int Id { get; set; }
    public int Ammontare { get; set; }
    public int Rata { get; set; }
    public DateOnly DataInizio { get; set; }
    public DateOnly DataFine { get; set; }
    public Cliente Intestatario { get; set; }

    public Prestito(int ammontare, int rata, DateOnly dataInizio, DateOnly dataFine, Cliente intestatario)
    {
        Id += 1;
        Ammontare = ammontare;
        Rata = rata;
        DataInizio = dataInizio;
        DataFine = dataFine;
        Intestatario = intestatario;
    }
}