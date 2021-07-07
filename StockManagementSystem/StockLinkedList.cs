using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    //linked list node that stores the stock object in nodes 
    public class Node
    {
        public StockUtility value { get; set; }
        //next hold the adress of next node
        public Node Next { get; set; }
        public Node(StockUtility stock)
        {
            this.value = stock;
            Next = null;
        }
    }
    public class StockLinkedList 
    {
        //initial head=null
        private Node head;
        public StockLinkedList()
        {

        }
        public StockLinkedList(params StockUtility[] value)
        {
            foreach (StockUtility temp in value)
            {
                AddLast(temp);

            }
        }
        //addlast method stores the data at last position
        public void AddLast(StockUtility stock)
        {
            Node  newNode = new Node (stock);
            if(head==null)
            {
                head = newNode;
            }

            else
            {
                Node temp = head;
                while(temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }

        }

        //the method return the total count of the node stored
        public  int Count()
        {
            int count = 0;
            if (head != null)
            {
                Node temp = head;
                while (temp != null)
                {
                    count++;
                    temp = temp.Next;
                }
            }
            return count;
        }
         
        //method to display the data 
        public StockUtility[] display()
        {
            int count= Count() ;
            StockUtility[] result = new StockUtility[count] ;
            int index = 0;
            Node temp = head;
            if (head == null)
            {
                return result;
            }
            else
            {
                while (temp.Next != null)
                {
                    result[index++] = temp.value;
                    temp = temp.Next;
                }
                result[index] = temp.value;
                return result;
            }
        }

        //methid to remove the node from the list
        public void RemoveData(StockUtility stock)
        {
            Node temp = head;
            Node prev = null;
            if(temp!=null && temp.value==stock)
            {
                head = temp.Next;

            }

            while (temp != null && temp.value != stock)
            {
                prev = temp;
                temp = temp.Next;
            }

            if(temp.value==stock)
            {
                prev.Next = temp.Next;
            }  
        }

    }
}
