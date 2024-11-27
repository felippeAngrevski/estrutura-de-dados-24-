using ListaGenerica;

List<double> numbers = new List<double>();

do{
    Console.WriteLine("Informe o número");
    string? numberStr = Console.ReadLine();

    if(!double.TryParse(numberStr, out double number)) break;

    numbers.Add(number);
    Console.WriteLine($"A média dos valores é {numbers.Average()}");
}while(true);

List<Person> people = new List<Person>();

Person p1 = new Person();
p1.Name = "Joaquim";
p1.Age = 12;
p1.Country = CountryEnum.PY;
people.Add(p1);

p1.Name = "Joaquim José da Silva Xavier";

people.Add(new Person(){
    Name = "Sharon Stone",
    Age = 60,
    Country = CountryEnum.PY,
});

Person p3 = new Person(){
    Name = "Arnold E-SuasNega",
    Age = 65,
    Country = CountryEnum.JP,
};
people.Add(p3);

//formas de percorrer a lista generica
foreach(Person p in people){
    Console.WriteLine(p.Name);
}

//for
for(int i = 0; i < people.Country; i++){
    Console.WriteLine($"Nome: {people[i].Name}");
}