namespace OtelBilgiSistemi.LinkList
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(OtelCalisan value);
        public abstract string DisplayElements();
    }
}
