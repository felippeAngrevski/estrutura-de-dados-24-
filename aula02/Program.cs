using Aula02;

Person person = new Person();

Person person1 = new Person ("Mauricio Goza", 40);
Console.WriteLine (person1.Name);

Person person2 = new Person ();
person2.Name = "Vladimir gay";
person2.Age = 70;
Console.WriteLine (person2.Name);
Console.WriteLine (person2.Age);

Person person3 = new Person (){
    Name = "Leonel Bingola",
    Age = 80
};
Console.WriteLine (person3.Name);
Console.WriteLine (person3.Age);