
// See https://aka.ms/new-console-template for more information


using System.Net.Security;

Banca intesa = new Banca("Intesa San Paolo");

Console.WriteLine("Sistema amministrazione banca " + intesa.Nome);

intesa.AggiungiCliente("Giacomo", "Di Nardo", "asdasfgsdfg2313", 1234);
//intesa.AggiungiCliente("Marco", "Bianchi", "dgfndsvujsdfn567", 3256);

Cliente ricercato = intesa.RicercaCliente("asdasfgsdfg2313");

Console.WriteLine(ricercato.Nome);
Console.WriteLine(ricercato.Cognome);
Console.WriteLine(ricercato.Stipendio);
Console.WriteLine(ricercato.CodiceFiscale);

Console.WriteLine();


//Cliente modificato = intesa.ModificaCliente(ricercato);

//Console.WriteLine();

//Console.WriteLine(modificato.Nome);
//Console.WriteLine(modificato.Cognome);
//Console.WriteLine(modificato.Stipendio);
//Console.WriteLine(ricercato.CodiceFiscale);

Console.WriteLine();

intesa.AggiungerePrestito(54000, 540, "asdasfgsdfg2313");
intesa.AggiungerePrestito(60000, 500, "asdasfgsdfg2313");
intesa.AggiungerePrestito(60000, 500, "asdasfgsdfg2313");
intesa.AggiungerePrestito(60000, 500, "asdasfgsdfg2313");
intesa.AggiungerePrestito(60000, 500, "dgfndsvujsdfn567");

Console.WriteLine("I prestiti del cliente {0}:", ricercato.Nome);
Console.WriteLine();

foreach (Prestito prestito in intesa.RicercaPrestito("asdasfgsdfg2313"))
{
    Console.WriteLine(prestito.Ammontare);
    Console.WriteLine(prestito.Rata);
    Console.WriteLine(prestito.Intestatario.Nome);
    Console.WriteLine(prestito.Intestatario.Cognome);
    Console.WriteLine();

}

Console.WriteLine(intesa.TotPrestiti("asdasfgsdfg2313"));

Console.WriteLine();

Console.WriteLine(intesa.RateDaPagare("asdasfgsdfg2313"));
