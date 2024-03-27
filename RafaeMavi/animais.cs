namespace RafaeMavi;
public class animais
{
    protected double fome;
    protected double sede;
    protected double alegria;

    public animais()
    {
        fome=0.01;
    }

    public void SetFome(double f)
    {
        fome=f;
    }

    public double Getfome()
    {
        return fome;
    }

}
