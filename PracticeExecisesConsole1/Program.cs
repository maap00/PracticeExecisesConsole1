

//EJERCICIO DE LA TIENDA DE LIMPIEZA
Console.WriteLine("Bienvenido a Productos de Limpieza Coder");
Console.WriteLine("Ingrese codigo de producto");
String code = Console.ReadLine().ToUpper();
string verificated;

verification(code);

while (verificated == "CodigoIncorrecto")
{
    Console.WriteLine("Ingrese un codigo valido");
    code = Console.ReadLine().ToUpper();
    verification(code);
}
Console.WriteLine("Ingrese cantidad del producto que desea adquirir");
int amount = int.Parse(Console.ReadLine());

calculeProduct(code, amount);

string verification(string code)
{
    if (code == "DES" || code == "JP" || code == "DET")
    {
        return verificated = "CodigoCorrecto";
    }
    else
    {
        return verificated = "CodigoIncorrecto";
    }
}
void calculeProduct(String code, int amount)
{
    if (code == "DES")
    {
        Console.WriteLine("Desodorante: 200$ por unidad");

        int totalAmount = 200 * amount;
        Console.WriteLine("Su total a pagar es: " + totalAmount.ToString() + "$");
        Console.WriteLine("Escriba 'Y' para confirmar o 'FIN' para cancelar");
        String CodeConfirm = Console.ReadLine().ToUpper();
        if (CodeConfirm == "Y")
        {
            Console.WriteLine("Gracias por su compra");
        }
        else if (CodeConfirm == "FIN")
        {
            Console.WriteLine("Compra cancelada");
        }

    }
    else if (code == "JP")
    {
        Console.WriteLine("Jabon en polvo: 300$ por unidad");
        int totalAmount = 300 * amount;
        Console.WriteLine("Su total a pagar es: " + totalAmount.ToString() + "$");
        Console.WriteLine("Escriba 'Y' para confirmar o 'FIN' para cancelar");
        String CodeConfirm = Console.ReadLine().ToUpper();
        if (CodeConfirm == "Y")
        {
            Console.WriteLine("Gracias por su compra");
        }
        else if (CodeConfirm == "FIN")
        {
            Console.WriteLine("Compra cancelada");
        }

    }
    else if (code == "DET")
    {
        Console.WriteLine("Detergente: 250$ por unidad");
        int totalAmount = 250 * amount;
        Console.WriteLine("Su total a pagar es: " + totalAmount.ToString() + "$");
        Console.WriteLine("Escriba 'Y' para confirmar o 'FIN' para cancelar");
        String CodeConfirm = Console.ReadLine().ToUpper();
        if (CodeConfirm == "Y")
        {
            Console.WriteLine("Gracias por su compra");
        }
        else if (CodeConfirm == "FIN")
        {
            Console.WriteLine("Compra cancelada");
        }
    }

}






