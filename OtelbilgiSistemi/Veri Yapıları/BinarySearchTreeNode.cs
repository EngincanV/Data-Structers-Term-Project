using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelbilgiSistemi.Veri_Yapıları
{
    public class BinarySearchTreeNode
    {
        public object data;
        public BinarySearchTreeNode left;
        public BinarySearchTreeNode right;

        public BinarySearchTreeNode(){ }

        public BinarySearchTreeNode(object data)
        {
            this.data = data;
            this.right = null;
            this.left = null;
        }
    }
}
