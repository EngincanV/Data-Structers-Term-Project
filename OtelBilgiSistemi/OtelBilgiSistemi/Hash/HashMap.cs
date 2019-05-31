using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi.Hash
{
    public class HashMap
    {
        HashEntry[] table;

        public HashMap(int TABLE_SIZE)
        {
            table = new HashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }
        public void AddOtel(int key, OtelKayit value)
        {
            int hash = (key % table.Length);
            while (table[hash] != null && table[hash].Anahtar != key)
                hash = (hash + 1) % table.Length;
            table[hash] = new HashEntry(key, value);
        }
        public string GetOtel(int key)
        {
            int hash = (key % table.Length);
            while (table[hash] != null && table[hash].Anahtar != key)
                hash = (hash + 1) % table.Length;
            if (table[hash] == null)
                return null;
            else
                return table[hash].Deger.Sehir + " - " + table[hash].Deger.Ilce;
        }
    }
}
