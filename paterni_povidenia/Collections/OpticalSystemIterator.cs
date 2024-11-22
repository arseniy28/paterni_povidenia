using System.Collections;
using System.Collections.Generic;
using paterni_povidenia.Models;

namespace paterni_povidenia.Collections
{
    public class OpticalSystemIterator : IEnumerator<Element>
    {
        private readonly List<Element> _elements;
        private int _position = -1;

        public OpticalSystemIterator(List<Element> elements)
        {
            _elements = elements;
        }

        public Element Current => _elements[_position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _elements.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
           
        }
    }
}
