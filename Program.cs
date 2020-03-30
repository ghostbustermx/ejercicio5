using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
   class LinkedList {
        public Node head;

        /* Linked list Node*/
    public class Node { 
        public int data; 
        public Node next; 
        public Node(int d) 
        { 
            data = d; 
            next = null; 
        } 
    }

    /* Inserta un nuevo nodo en el frente de la lista. */
    public void push(int new_data) 
    { 
        /* 1 & 2: Posiciona el nodo & 
                setea la data*/
        Node new_node = new Node(new_data); 
  
        /* 3. Hace el siguiente nodo como head */
        new_node.next = head; 
  
        /* 4. Mueve el head al punto del nuevo nodo */
        head = new_node; 
    } 

    // Devuelve true si hay un ciclo en la linkedlist 
    // si no devuelve false. 
    public static bool detectLoop(Node h) 
    { 
        HashSet<Node> s = new HashSet<Node>(); 
        while (h != null) { 
  
            if (s.Contains(h)) 
                return true; 

            s.Add(h); 
  
            h = h.next; 
        } 
  
        return false; 
    } 


        public static void Main(string[] args)
        { 
        LinkedList llist = new LinkedList(); 
  
        llist.push(20); 
        llist.push(4); 
        llist.push(15); 
        llist.push(10); 
  
        /*Crea un loop para probar */
        llist.head.next.next.next.next = llist.head; 
  
        if (detectLoop(llist.head)) 
            Console.WriteLine("Ciclo encontrado"); 
        else
            Console.WriteLine("Sin Ciclo"); 
    } 
    }
}
