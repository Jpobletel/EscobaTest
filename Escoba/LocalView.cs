namespace T2;

public class LocalView : View
{
    protected override void Write(string mensaje) => Console.Write(mensaje);
    

    protected override string ReadLine() => Console.ReadLine();
}