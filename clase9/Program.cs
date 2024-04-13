using clase9.clasebase.clasehija;
nintendo sw = new nintendo();
sw.EsPortatil = true;
sw.aniolanzamiento = 2017;
sw.marca = "nintengo switch";

string resultado = sw.MostrarDetallesNintendo();
Console.WriteLine(resultado);

playstation ps = new playstation();
ps.marca = "playstation 4";
string resul = ps.MostrarDetallesPS();
Console.WriteLine(resul);