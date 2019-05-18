using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelbilgiSistemi.Veri_Yapıları
{
    public class LinkedList : LinkedListADT
    {
        public override void DeleteFirst()
        {
            if(Head != null)
            {
                Node tempHeadNext = this.Head.Next;
                if (tempHeadNext == null)
                    Head = null;
                else
                    Head = tempHeadNext;
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node lastNode = Head;
            Node lastPrevNode = null;
            while(lastNode.Next != null)
            {
                lastPrevNode = lastNode;
                lastNode = lastNode.Next;
            }
            Size--;
            lastNode = null;

            if (lastPrevNode != null)
                lastPrevNode.Next = null;
            else
                Head = null;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while(item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }
            return temp;
        }

        public override void InsertFirst(Calisan value)
        {
            Node tmpHead = new Node();
            tmpHead.Data = value;

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }

        public override void InsertLast(Calisan value)
        {
            //Eski sonuncu node, Head'den başlanarak set ediliyor
            Node oldLast = Head;

            if (Head == null)
                //Hiç kayıt eklenmediği için InsertFirst çağrılabilir
                InsertFirst(value);
            else
            {
                //Yeni sonuncu node yaratılıyor
                Node newLast = new Node
                {
                    Data = value
                };

                //Eski sonuncu node bulunuyor
                //Tail olsaydı sonuncuyu bulmaya gerek yoktu.
                while (oldLast.Next != null)
                {

                    oldLast = oldLast.Next;

                }

                //Eski sonuncu node referansı artık yeni sonuncu node'u gösteriyor
                oldLast.Next = newLast;

                //Bağlı listedeki eleman sayısı bir arttı
                Size++;
            }
        }
    }
}
