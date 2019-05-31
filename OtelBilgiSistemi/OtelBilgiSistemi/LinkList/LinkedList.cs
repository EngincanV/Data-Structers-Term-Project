namespace OtelBilgiSistemi.LinkList
{
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(OtelCalisan value)
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
        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp +=item.Data.Id+ "" + item.Data.Ad +  " " +item.Data.Soyad + "-->" ;
                item = item.Next;
            }

            return temp;
        }
    }
}
