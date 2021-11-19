using Ovelse7_7;

Vare[] indkob = new Vare[3];

Vare maelk = new Vare();
maelk.Navn = "Mælk";
maelk.Pris = 10.95;

Vare ost = new();
ost.Navn = "Ost";
ost.Pris = 55.50;

Vare mel = new();
mel.Navn = "Mel";
mel.Pris = 12.95;

Kasseapparat apparat = new();
apparat.UdskrivBon(indkob);