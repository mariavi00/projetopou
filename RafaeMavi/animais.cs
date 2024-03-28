namespace RafaeMavi;
public class animais
{
    protected double fome;
    protected double sede;
    protected double alegria;

    public animais()
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

}
