//Programa que permite vizualizar los departamentos de Nicaragua con
//su cantidad Poblacional
//Encuentra Mayor, Menor, sumas y ordena los datos
using Departamentos;
//Lista de Departamentos
List<depto>lstDeptos=new List<depto>()
{
    new depto("Boaco", 185013),
    new depto("Carazo", 197139),
    new depto("Chinandega", 439906),
    new depto("Chontales", 190863),
    new depto("Costa Caribe Norte", 530586),
    new depto("Costa Caribe Sur", 414543),
    new depto("Estelí", 229866),
    new depto("Granada", 214317),
    new depto("Jinotega", 475630),
    new depto("León", 421050),
    new depto("Madriz", 174744),
    new depto("Managua", 1546939),
    new depto("Masaya", 391903),
    new depto("Matagalpa", 593503),
    new depto("Nueva Segovia", 271581),
    new depto("Rio San Juan", 135446),
    new depto("Rivas", 182645)
};
//Encontrar el mayor y el menor (población)
depto minDepto = lstDeptos.OrderBy(d => d.population).First();
depto maxDepto = lstDeptos.OrderBy(d => d.population).Last();
//Ordenar los departamentos
var DeptOrdenado = lstDeptos.OrderBy(d => d.population);
//Mostrar Departamentos Ordenados
foreach (var item in DeptOrdenado)
 Console.WriteLine($"{item.Name,-20}==>{item.population,10:N0}");
 //Mostrar el mayor y el menor
 Console.WriteLine($"Dpto con menor población: {minDepto.Name}");
 Console.WriteLine($"Dpto con mayor población: {maxDepto.Name}");
 //Sumar todas las poblaciones con SUM de LINQ
 int total = lstDeptos.Select(d=> d.population).Sum();
 Console.WriteLine($"Población General:{total:N0}");
