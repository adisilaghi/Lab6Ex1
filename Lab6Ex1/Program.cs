/*• Ex 1
Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
metoda care va calcula volumul acestuia.
Folositi o clasa care va modela un dulap.
 Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
 Cele trei campuri vor fi initializate cu ajutorul constructorului
 Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
afisati rezultatul.*/

Closet closet = new(10, 5, 2);

int closetVolume = closet.volume();
Console.WriteLine("The volume of the closet is: " + closetVolume);


class Closet
{
    private int length;
    private int width;
    private int height;

    /// <summary>
    /// Enter values for volume calculations
    /// </summary>
    /// <param name="closet-width"></param>
    /// <param name="closet-height"></param>
    /// <param name="closet-length"></param>
    public Closet(int closetwidth, int closetheight, int closetlength)
    {
        this.width = closetwidth;
        this.height = closetheight;
        this.length = closetlength;
        
    }

    public int volume()
    {
        int volume = width* height * length;
        return volume;  
    }
            

}