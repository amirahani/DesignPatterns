using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator_SequenceLibrary
{
    public class FibonacciSequence : IEnumerable<int>
    {
        public int NumberOfValues { get; set; }

        public FibonacciSequence(int numberOfValues)
        {
            NumberOfValues = numberOfValues;
        }

        public IEnumerator<int> GetEnumerator()
        {
            //return new FibonacciEnumerator(NumberOfValues);

            int _previousTotal = 0;
            int _currentTotal = 0;


            for (int i = 0; i < NumberOfValues; i++)
            {
                if (i == 0)
                {
                    _currentTotal = 1;
                }
                else
                {
                    int _newTotal = _previousTotal + _currentTotal;
                    _previousTotal = _currentTotal;
                    _currentTotal = _newTotal;
                }
                yield return _currentTotal;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
