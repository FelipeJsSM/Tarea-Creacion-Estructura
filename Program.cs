public abstract class MiembroDeLaComunidad
{
    protected string Nombre { get; set; }

    public MiembroDeLaComunidad(string nombre)
    {
        Nombre = nombre;
    }

    public abstract void MostrarInformacion();
}

public class Empleado : MiembroDeLaComunidad
{
    public Empleado(string nombre) : base(nombre) { }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Empleado: {Nombre}");
    }
}

public class Estudiante : MiembroDeLaComunidad
{
    public Estudiante(string nombre) : base(nombre) { }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Estudiante: {Nombre}");
    }
}

public class ExAlumno : MiembroDeLaComunidad
{
    public ExAlumno(string nombre) : base(nombre) { }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"ExAlumno: {Nombre}");
    }
}

public class Docente : Empleado
{
    public Docente(string nombre) : base(nombre) { }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Docente: {Nombre}");
    }
}

public class Administrativo : Empleado
{
    public Administrativo(string nombre) : base(nombre) { }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Administrativo: {Nombre}");
    }
}

public class Administrador : Docente
{
    public Administrador(string nombre) : base(nombre) { }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Administrador: {Nombre}");
    }
}

public class Maestro : Docente
{
    public Maestro(string nombre) : base(nombre) { }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Maestro: {Nombre}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado = new Empleado("Juan");
        Estudiante estudiante = new Estudiante("Ana");
        ExAlumno exAlumno = new ExAlumno("Carlos");
        Docente docente = new Docente("María");
        Administrativo administrativo = new Administrativo("Pedro");
        Administrador administrador = new Administrador("Luis");
        Maestro maestro = new Maestro("Sofía");

        List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>()
        {
            empleado,
            estudiante,
            exAlumno,
            docente,
            administrativo,
            administrador,
            maestro
        };

        foreach (MiembroDeLaComunidad miembro in miembros)
        {
            miembro.MostrarInformacion();
        }
    }
}
