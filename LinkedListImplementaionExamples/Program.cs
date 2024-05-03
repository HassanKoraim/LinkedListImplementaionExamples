using System.Xml.Linq;
using System.Xml.Serialization;

namespace LinkedListImplementaionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> node = new Node<int>(1);
           // var curr = node;
          //  
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
           // node.setNext(node2);

            LList<int> nodes = new LList<int>();
            nodes.insert(node);
            
            nodes.insert(node2);
           // nodes.append(3);
            // Console.WriteLine(node.getValue());

            nodes.display();
        }
    }
}
