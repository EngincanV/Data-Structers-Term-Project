using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelbilgiSistemi.Veri_Yapıları
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(Calisan value);
        public abstract void InsertLast(Calisan value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract string DisplayElements();
    }
}
