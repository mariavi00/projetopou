namespace RafaeMavi;
public class Animais
{
    protected double fome;
    protected double sede;
    protected double alegria;

    public Animais()
    {
    }

    public void SetFome(double f)
    {
        fome=f;
    }

    public double GetFome()
    {
        return fome;
    }

    public void SetSede(double s)
    {
        sede=s;
    }

    public double GetSede()
    {
        return sede;
    }

    public void SetAlegria(double a)
    {
        alegria=a;
    }

    public double GetAlegria()
    {
        return alegria;
    }

    protected string Arquivo;

    public string GetArquivo()
    {
        return Arquivo;
    }

}
