using System;

namespace Vsite.CSharp
{
	abstract class Životinja {
		public abstract void PokreniSe();
	}
    class Riba	 :Životinja
    {
		override public void  PokreniSe()
        {
            Console.WriteLine("Plivam");
        }
    }

    class Gmaz	: Životinja
    {
		override public void  PokreniSe()
        {
            Console.WriteLine("Gmižem");
        }
    }

    class Ptica	: Životinja
    {
		override public void  PokreniSe()
        {
            Console.WriteLine("Letim");
        }
    }

    class Sisavac  : Životinja 
    {
      override  public void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }
    }
}
