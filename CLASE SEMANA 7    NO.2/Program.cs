
void adivinar()

{
    const int oportuidades = 4;
    int numerocpu, numerousuario;
    byte intentos, banderadecontrol;
    string linea;
    Random ran = new Random();


    do
    {
        numerocpu = Convert.ToInt32(ran.Next(1, 20));

        numerocpu = Convert.ToInt32(ran.Next(100));
        Console.WriteLine(numerocpu);

    }
    while (!(((numerocpu >= 1) & (numerocpu <= 20))));

    intentos = 1;
    banderadecontrol = 0;

    do
    {

        Console.WriteLine("Estoy pensando un numero, cual sera?");
        linea = Console.ReadLine();
        numerousuario = Convert.ToInt32(linea);
        if (numerocpu == numerousuario)
        {
            Console.WriteLine("adivinaste!!");
            banderadecontrol = 1;
        }
        else
        {
            if ((numerousuario > numerocpu))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            intentos++;
        }

    } while (((intentos <= oportuidades) & (banderadecontrol == 0)));
    if (banderadecontrol == 0)
    {
        Console.WriteLine("el numero fue" + numerocpu);
    }

    adivinar();


}

void mayorm()
{
    int mayor = 0;
    int numero = 0;
    int menor = 10;

    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        numero = random.Next(10);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;

        }
        if (numero < menor)
        {

            menor = numero;
        }

    }
    Console.WriteLine("El mayor es=" + mayor);
    Console.WriteLine("El menor es=" + menor);

}
mayorm();

void catcher()

{
    int cantidad = 0;
    Console.WriteLine("Ingrese ua cantidad ");
    try
    {
        cantidad = int.Parse(Console.ReadLine());
        cantidad = cantidad / 0;

    }
    catch (FormatException fex)
    {
        Console.WriteLine("ingreso mal un numero" + fex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("hay un error de otro tipo" + ex.Message);

    }
    if (cantidad > 0)
    {
        Console.WriteLine("cantidad ingresada=" + cantidad);
    }
}

catcher();

using System.Runtime.CompilerServices;

void ejemploarreglo()
{
    int[] numero = new int[5];

    int suma = 0;
    numero[0] = 45;
    numero[1] = 50;
    numero[2] = 68;
    numero[3] = 70;
    numero[4] = 86;
    numero[5] = 92;
    numero[6] = 89;
    int prom = numero.Length;
    int elementos = 10;
    Random ram = new Random();
    string[] nombres = new string[elementos];
    nombres[0] = "maria";
    nombres[1] = "maria";
    nombres[2] = "maria";
    nombres[3] = "maria";
    nombres[4] = "maria";
    nombres[5] = "maria";
    nombres[6] = "maria";
    nombres[7] = "maria";
    nombres[8] = "maria";
    nombres[9] = "maria";




    for (int i = 0; i < elementos; i++)
    {
        suma = suma + numero[i];
        Console.WriteLine(numero[1]);
        Console.WriteLine("el promedio es" + suma / prom);
        Console.WriteLine(nombres[i]);
    }

    Console.WriteLine("numero en 2 pos" + numero[2]);



}

ejemploarreglo();


