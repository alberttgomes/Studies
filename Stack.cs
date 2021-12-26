using System;

namespace StructureStack
{
    public class Pilha
    {
        Position first;

        public void Stack(object item)
        {
            first = new Position(first, item);
        }

        public object Unstacks()
        {
            if(first == null)
            {
                throw new InvalidOperationException();
            }

            object result = first.item;
            first = first.next;
            
            return result;
        }
    }

    class Position
    {
        public Position next;
        public  object item;
        public Position(Position next, object item)
        {
            this.next = next;
            this.item = item;
        }
    }
    
}
