using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPBad
{
    // Liskov Substitution Prenciple

    public abstract class BasePhone
    {
        // Bir class abstrac ise nesne örneği alamassınız,
        // O yüzden mümkün olduğunca base classlarınızı mümkün oldukça abstrac class tanımlayabilirsiniz.
        public void call()
        {
            Console.WriteLine("Arama yapıldı");
        }

        public abstract void TakePhoto();
    }

    public class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Fotoğaf çekildi");
        }
    }

    public class Nokia3310 : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException(); 
        }
    }

}
