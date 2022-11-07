
// See https://aka.ms/new-console-template for more information


using System.Net.Security;

Banca intesa = new Banca("Intesa San Paolo");

Console.WriteLine("Sistema amministrazione banca " + intesa.Nome);

intesa.AggiungiCliente("Giacomo", "Di Nardo", "asdasfgsdfg2313", 1234);

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

intesa.AggiungerePrestito(1, 54000, 540, "asdasfgsdfg2313");
intesa.AggiungerePrestito(2, 60000, 500, "asdasfgsdfg2313");
intesa.AggiungerePrestito(2, 60000, 500, "asdasfgsdfg2313");
intesa.AggiungerePrestito(2, 60000, 500, "asdasfgsdfg2313");
intesa.AggiungerePrestito(2, 60000, 500, "asdasfgsdfg2313");

Prestito prestitoRicercato = intesa.RicercaPrestito("asdasfgsdfg2313");


Console.WriteLine(prestitoRicercato.Ammontare);
Console.WriteLine(prestitoRicercato.Rata);
Console.WriteLine(prestitoRicercato.Intestatario.Nome);
Console.WriteLine(prestitoRicercato.Intestatario.Cognome);

Console.WriteLine();

Console.WriteLine(intesa.TotPrestiti("asdasfgsdfg2313"));

Console.WriteLine();

Console.WriteLine(intesa.RateDaPagare("asdasfgsdfg2313"));
