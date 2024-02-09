string name = "Ewa";
var sex = "Kobieta";
var age = 30;

if (sex == "Kobieta" && age < 30)
    Console.WriteLine("Kobieta poni¿ej 30 roku ¿ycia.");

else if (name == "Ewa" && age == 30)
    Console.WriteLine("Ewa, lat 30.");

else if (!(sex == "Kobieta") && age < 18)
    Console.WriteLine("Niepe³noletni mê¿czyzna");