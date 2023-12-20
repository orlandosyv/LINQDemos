using LINQDemos;
using LINQDemos.Models;
using LINQDemos.Utils;


#region Action

//void SayHello(string name)
//{
//    Console.WriteLine(name);
//}

//Action sayHello = () => Console.WriteLine("Hello");

//sayHello();



#endregion

#region Func

//double GetPI()
//{
//    return 3.1416;
//}

//Func<double> getPI = () => 3.1416;

//var result1 = getPI();

//Console.WriteLine(result1);

//double Add(double arg1, double arg2)
//{
//    return arg1 + arg2;
//}

//Func<double, double, double> add = (arg1, arg2) => arg1 + arg2;

//var result2 = add(2, 2);
//Console.WriteLine(result2);

#endregion

#region Select

////1.- Selecciona todos los nombres (sin apellidos) de los estudiantes


////2.- Selecciona todos los nombres y apellidos de los estudiantes


#endregion

#region Deferred execution example


//var names = DBContext.Students.Select(s => s.FirstName);

//DBContext.Students[0] = new Student
//{
//    FirstName = "New",
//    LastName = "Student",
//    Id = 100,
//    UniversityId = 10
//};

//Console.WriteLine("==============");
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Where
//3.- Selecciona el nombre de todas las universidades dentro de USA


//foreach(var item in USAUniversities)
//{
//    Console.WriteLine(item);
//}
#endregion

#region OrderBy

//4.- Selecciona el nombre de todas las universidades ordenadas por nombre



//5.- Selecciona el nombre de todas las universidades ordenadas por nombre de forma ascendente,


#endregion

#region GroupBy

//6.- Utilizando agrupaciones, imprime el nombre del nombre del país y el número de universidades que hay en ese país,
//y a continuación el nombre de cada universidad en ese país en un formato de lista


#endregion

#region Count

//7.- Imprime la cantidad de universidades en Canadá


#endregion

#region Distinct

//8.- Imprime la cantidad de países en los que hay universidades


#endregion

#region Join

//9.- Imprime el Nombre, apellido y país de universidad de todos los estudiantes
//var joinNameLastNCountry = DBContext.Students.Join(
//    DBContext.Universities, 
//    u => u.UniversityId, 
//    u => u.Id,
//    (s, u) => new { s.FirstName, s.LastName, u.Name }    
//    );

//foreach (var item in joinNameLastNCountry)
//{ Console.WriteLine(item); }

#endregion

#region More examples

#region Partitioning data
//1.- Obtén los dos primeros objetos de estudiantes de la lista

//2.- Obten el tercer y cuarto objeto de estudiantes de la lista


#endregion

#region Quantifier operations

//3.- Obtén el valor booleano que indique si hay algún estudiante con el apellido "Peterson"


//4.- Obtén el valor booleano que indique si todos los estudiantes tienen un apellido


#endregion



#region First & FirstOrDefault
//5.- Obten el primer estudiante que tenga el apellido "Williams"


#endregion


#region SelectMany
//6.- Obtén una primer colección de estudiantes cuyo nombre empiece con la letra "J"
// Después, obtén una segunda colección de estudiantes cuyo nombre empiece con la letra "A"
// A continuación, crea una nueva lista de listas de estudiantes, y agrega las dos listas anteriores
// Finalmente, crea una nueva colección que contenga todos los estudiantes como elementos de la colección


#endregion

#region Except
//7.- Obtén una primer colección de estudiantes cuyo nombre empiece con las letras "A, J y T"
// Después, obtén una segunda colección de estudiantes cuyo apellido empiece con las letras "S, B y W"
// Excluye los estudiantes cuyos nombres comiencen con "A", "J", o "T" de la lista de estudiantes


#endregion


#region Intersect
//8.- Obtén una primer colección de estudiantes cuyo nombre empiece con las letras "A, J y T"
// Después, obtén una segunda colección de estudiantes cuyo apellido empiece con las letras "S, B y W"
// Intersecta los estudiantes que se encuentre en ambas listas

#endregion


#region Union

//9.- Obtén una primer colección de estudiantes cuyo nombre empiece con las letras "A, J y T"
// Después, obtén una segunda colección de estudiantes cuyo apellido empiece con las letras "S, B y W"
// Obtén la colección de estudiantes no repetidos de ambas colecciones


#endregion


#region Reverse
//10.- Obtén la colección de todas las universidades ordenadas por nombre, y a continuación invierte el orden de la colección


#endregion


#endregion
//Printer.Print(countryQuantity);