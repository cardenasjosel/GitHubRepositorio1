using System.Collections;
//Definicion e inicializacion de arrglos en pararlelo
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
          .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
          .ToDictionary(x => x.Clave, x => x.Valor);
//Ordenando el diccionario
var ordenado = diccionario. OrderBy(x=> x.Value).ToDictionary(x=> x.Key, x =>x.Value);
//fijando los nombres de los depart, menor - mayor poblacion
string minDepKey = ordenado.First().Key;
string maxDepKey = ordenado.Last().Key;
//reaccionacion de los areglos en paralelo
Departamento= ordenado.Keys.ToArray();
Poblacion = ordenado.Values.ToArray();
//Mostrar arreglos
for (var i = 0; i < Poblacion.Length; i++)
   Console.WriteLine($"{Departamento[i], 20} ==> {Poblacion[i],10:N0}");
//Sumar todas las poblaciones con LinQ
Console.WriteLine($"Población General:{Poblacion.Sum():N0}");
   Console.WriteLine($"Departamento con mayor Población:{maxDepKey}");
   Console.WriteLine($"Departamento con menor Población:{minDepKey}");
