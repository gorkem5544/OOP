using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService logger)
        {
            krediManager.Hesapla();
            logger.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
        
    }
}
