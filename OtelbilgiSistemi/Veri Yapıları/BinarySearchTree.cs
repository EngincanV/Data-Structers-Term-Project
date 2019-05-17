using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelbilgiSistemi.Veri_Yapıları
{
    public class BinarySearchTree
    {
        private BinarySearchTreeNode root;

        public BinarySearchTree() { }

        public BinarySearchTree(BinarySearchTreeNode root)
        {
            this.root = root;
        }

        public void Add(int value)
        {
            //create parent
            BinarySearchTreeNode tempParent = new BinarySearchTreeNode();

            //start with root and go then
            BinarySearchTreeNode tempSearch = root;

            while(tempSearch != null)
            {
                tempParent = tempSearch;
                if (value == (int)tempSearch.data)
                    return;
                else if (value < (int)tempSearch.data)
                    tempSearch = tempSearch.left;
                else
                    tempSearch = tempSearch.right;
            }

            //create the value what we'll add
            BinarySearchTreeNode addValue = new BinarySearchTreeNode(value);

            if (root == null)
                root = addValue;
            else if (value < (int)tempParent.data)
                tempParent.left = addValue;
            else
                tempParent.right = addValue;
        }
   
    }
}
