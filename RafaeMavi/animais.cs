namespace RafaeMavi;
public class Animais
{
    protected double fome;
    protected double sede;
    protected double alegria;
    protected string Arquivo;
    protected string ArquivoMorto;
    protected bool morto;

    public Animais()
    {
    }

    public void SetFome(double f)
    {
            if(f>1)
            fome=1;
            else if (f<=0)
        {
            morto=true;
            fome=0;
        }
            else
            fome=f;
     
    }

    public double GetFome()
    {
        return fome;
    }

    public void SetSede(double s)
    {
          if(s>1)
            sede=1;
            else if (s<=0)
        {
            morto=true;
            sede=0;
        }
            else
            sede=s;
     
    }

    public double GetSede()
    {
        return sede;
    }

    public void SetAlegria(double a)
    {
          if(a>1)
            alegria=1;
            else if (a<=0)
        {
            morto=true;
            alegria=0;
        }
            else    
        alegria=a;
    }

    public double GetAlegria()
    {
        return alegria;
    }


    public string GetArquivo()
    {
        if(morto)
        return ArquivoMorto;
        else 
        return Arquivo;
    }

    public bool Getmorto()
    {
      return morto;
    }

}
