internal class ClsConsole
{
    public string marca { get; set; }
    public int aniolanzamiento { get; set; }
    public void mostrardetalles()
    {
        Console.WriteLine($"algo nuevo marca: {marca}, año lanzamiento: {aniolanzamiento}");
    }
}