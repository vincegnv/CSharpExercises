using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MySortedList<T> : Program, ICloneable where T : IComparable<T>
    {
        public List<T> Collection
        {
            get;
            set;
        }

        public MySortedList()
        {
            this.Collection = new List<T>();
        }

        public void Add(T t)
        {
            if (Collection.Count == 0 || AddedElementBiggerOrEqualTo(Collection.Last(), t))
            {
                Collection.Add(t);
            }
            else if (AddedElementSmallerOrEqualTo(Collection.First(), t))
            {
                Collection.Insert(0, t);
            } 
            else
            {
                int start = 0;
                int end = Collection.Count - 1;
                int middle = (start + end) / 2;

                if (start == middle)
                {
                    Collection.Insert(end, t);
                }
                else
                {
                    while (start <= middle && end >= middle)
                    {
                        middle = (start + end) / 2;
                        if (AddedElementSmallerOrEqualTo(Collection[middle], t)) //Collection[middle] >= t
                        {
                            if (middle - start == 1)
                            {
                                Collection.Insert(middle, t);
                                break;
                            }
                            end = middle;
                        }
                        else if (AddedElementBiggerOrEqualTo(Collection[middle], t)) //Collection[middle] < t
                        {
                            if (end - middle == 1)
                            {
                                Collection.Insert(end, t);
                                break;
                            }
                            start = middle;
                        }
                    }
                }
            }

        }

        private bool AddedElementSmallerOrEqualTo(T collectionElement, T addedElement)
        {
            return collectionElement.CompareTo(addedElement) >= 0;
        }

        private bool AddedElementBiggerOrEqualTo(T collectionElement, T addedElement)
        {
            return collectionElement.CompareTo(addedElement) <= 0;
        }

        public void print()
        {
            foreach (T s in Collection)
            {
                Console.Write(s.ToString() + " ");
            }
            Console.WriteLine();
        }


        public object Clone()
        {
            MySortedList<T> l = new MySortedList<T>();
            l.Collection = new List<T>(Collection);
            return l;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T t in Collection)
            {
                sb.Append(t.ToString());
                sb.Append(" ");
            }

            return sb.ToString().Trim(); ;
        }
    }
}
