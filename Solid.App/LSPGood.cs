using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPGood
{
    // Liskov Substitution Prenciple

    public interface ITakePhoto
    {
        void TakePhoto();
    }
    public abstract class BasePhone
    {
        // Bir class abstrac ise nesne örneği alamassınız,
        // O yüzden mümkün olduğunca base classlarınızı mümkün oldukça abstrac class tanımlayabilirsiniz.
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }


    }

    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi");
        }
    }

    public class Nokia3310 : BasePhone
    {

    }

}
