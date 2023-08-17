
Console.OutputEncoding = System.Text.Encoding.UTF8;

string [] posao = new string [3] { "programer", "devops", "dizajner" };
string [] ucenik = new string [3] { "Pero peric", "Marko maric", "Maja perko"};
int [] ocjena = new int [3] { 2, 3, 5};

Person user = new Person ("Matija", "Katić", 32, true, posao[0]);
Person user2 = new Person ("Maja", "Perić", 23, false, posao[2]);
Person user3 = new Person ("Pero", "Perić", 33, true, posao[1]);
Person user4 = new Person ("Marko", "Perić", 34, false, posao[2]);
Person user5 = new Person ("Domagoj", "Perić", 31, true, posao[1]);

List<Person> userList = new List<Person> ();
List<Person> userList2 = new List<Person> ();

userList.Add(user);
userList.Add(user2);
userList.Add(user3);

userList2.Add(user4);
userList2.Add(user5);

PrintUser print = new PrintUser();
print.printUsers(userList);
print.printUsers(userList2);




class Person {
   public string ime;
   public string prezime;
   public int age;
   public bool gender;
   public string posao; 

  public Person(string ime, string prezime, int age, bool gender, string posao) {
    this.ime = ime;
    this.prezime = prezime;
    this.age = age;
    this.gender = gender;
    this.posao = posao;

  } 
}
 
 class PrintUser {
  public void printUsers(List<Person> users)  {
     //users.ForEach(x => {
     //Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime);
     //Console.WriteLine("Dob: {0}", x.age);
     //Console.WriteLine("spol: {0}", x.gender ? "Muško" : "Žensko");
     //Console.WriteLine("Posao: {0}", x.posao);


      //});
       foreach (Person x in users) {
        Console.WriteLine( "Ime i prezime: {0}", x.ime, x.prezime);
        Console.WriteLine( "Dob: {0}", x.age);
        Console.WriteLine("Spol: {0}", x.gender ? "Muško" : "Žensko");
        Console.WriteLine("Posao: {0}", x.posao);
      }
   }
} 
  

      

  












 



















