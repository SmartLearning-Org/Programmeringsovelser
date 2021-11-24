using Ovelse7_7;

Vare ost = new();
ost.Navn = "Ost";
ost.Pris = 55.95;

Vare maelk = new();
maelk.Navn = "Mælk";
maelk.Pris = 9.95;

Vare mel = new();
mel.Navn = "Mel";
mel.Pris = 12.50;

Vare[] indkob = { ost, maelk, mel };

Kasseapparat apparat = new();
apparat.UdskrivBon(indkob);