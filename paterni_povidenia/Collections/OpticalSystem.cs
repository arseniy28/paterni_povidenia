using System.Collections;
using System.Collections.Generic;
using paterni_povidenia.Collections;
using paterni_povidenia.Models;

namespace paterni_povidenia.Collections
{
    public class OpticalSystem : IEnumerable<Element>
    {
        private readonly List<Element> _elements = new List<Element>();

        public void AddElement(Element element)
        {
            _elements.Add(element);
        }

        public IEnumerator<Element> GetEnumerator()
        {
            return new OpticalSystemIterator(_elements);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

