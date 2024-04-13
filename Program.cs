/*using Clase_9_Herencia.ClaseBase;
ClsConsola miConsola= new ClsConsola(); ;

miConsola.AnioLanzamiento = 1997;
miConsola.Marca = "Nintendo 64";
miConsola.MostrarDetalles();*/

using Clase_9_Herencia.ClaseHija;

Nintendo sw= new Nintendo();
sw.EsPortatil = true;
sw.AnioLanzamiento = 2017;
sw.Marca = "Nintendo Switch";
string resultado= sw.MostrarDellasesNintendo();
Console.WriteLine(resultado);
Console.WriteLine();

PlayStation ps= new PlayStation();
ps.ModeloControlador = "DualShock ";
ps.AnioLanzamiento = 2015;
ps.Marca = "Play Station 4";
string resul = ps.MostrarDetallesPs();
Console.WriteLine(resultado);
Console.WriteLine();

XBOX xb = new XBOX();
xb.gamepass = "Si";
xb.AnioLanzamiento = 2015;
xb.Marca = " XBOX ONE";
string re = xb.MostrarDetallesXB();
Console.WriteLine(re);
Console.WriteLine();
