using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    class Builder {
        public IEnumerable<int> BuildIntegerSequence (int start, int count) {
            var integers = Enumerable.Range(start, count);
            return integers;
        }

        public IEnumerable<string> BuildAlphabet () {
            var strings = BuildIntegerSequence(0,26)
                .Select(i => (((char)('A' + i)).ToString()));

            return strings;
        }

        public IEnumerable<int> BuildRandomNumberSequence () {
            Random random = new Random();

            var integers = Enumerable.Range(0, 100)
                .Select(i => random.Next(0, 100));

            return integers;
        }
    }
}
