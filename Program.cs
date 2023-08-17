
//using System.Security.Cryptography.X509Certificates;

using System.Security.Cryptography.X509Certificates;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//1. a) Stvorite array s nizom brojeva. b) Stvorite objek u kojemu se nalazi funkcija koja kvadrira svaki broj i ispisuje rezultat

//int [] brojevi = new int [4] {2, 4, 6, 8};

//Mnozenje rezultat = new Mnozenje ();
//rezultat.kvadriranje(brojevi);

//class Mnozenje {
  //public void kvadriranje (int[] data) {
    //foreach(int x in data) {
      //Console.WriteLine("Broj:" + x );
      //Console.WriteLine(x * x);
   // }
  
  //}
//}


//2. a) Stvorite Listu s popisom učenika (Student klasa i Lista<Student>) b) Stvorite objekt koji će funkciju koja će nam ispisivati korisnike

Student ucenik = new Student ("Patricia", 15, "Ekonomska škola" );
Student ucenik2 = new Student ("Leon", 16, "Poljoprivredna škola");
Student ucenik3 = new Student ("Dominik",18, "Tehnička škola");
Student ucenik4 = new Student ("Kiara", 17, "Opća gimnazija");

List<Student> ucenikList = new List<Student> ();
ucenikList.Add(ucenik);
ucenikList.Add(ucenik2);
ucenikList.Add(ucenik3);
ucenikList.Add(ucenik4);

PrintStudent lista = new PrintStudent();
lista.PrintStudents(ucenikList);

class Student {
  public string ime;
  public int age;
  public string skola;

  public Student (string ime, int age, string skola) {
    this.ime = ime;
    this.age = age;
    this.skola = skola;

  }
}

class PrintStudent {
  public void PrintStudents (List<Student> ucenici) {
    foreach (Student x in ucenici) {
      Console.WriteLine("Ime: {0}", x.ime);
      Console.WriteLine("Dob: {0}", x.age);
      Console.WriteLine("Skola: {0}", x.skola);
      Console.WriteLine("***********************************");
    }
    
  }

}


  












 



















