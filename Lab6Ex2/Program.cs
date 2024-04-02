/*
Scrieti un program care va modela un autoturism. Un autoturism va avea o
marca (string), un numar de inmatriculare (string), precum si o
capacitate cilindrica(int).
Autoturismul va avea:
 Campurile corespunzatoare caracteristicilor autoturismului.
 Un constructor care va initializa campurile acestuia
 O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
numarDeInmatriculare, capacitateCilindrica”.
Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
xml pentru metodele publice.
Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
metodele “Tipareste”*/

CarBrand carDetailsTop = new("Dacia","BH02BH", 1200);
CarBrand carDetailsMid = new("Mercedes", "CJ02CJ", 2000);

carDetailsTop.print();
carDetailsMid.print();

class CarBrand
{
    private string brand;
    private string plateNumber;
    private int ep;

    /// <summary>
    /// Car Details:
    /// </summary>
    /// <param name="brand"></param>
    /// <param name="plateNumber"></param>
    /// <param name="ep"></param>
    public CarBrand(string brand, string plateNumber, int ep)
    {
        this.brand = brand;
        this.plateNumber = plateNumber;
        this.ep = ep;
    }
    public void print()
    {
        Console.WriteLine(brand + " " + plateNumber + " " + ep);

    }

}