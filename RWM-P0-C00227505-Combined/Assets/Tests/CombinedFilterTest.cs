using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 4, 6, 6, 6, 6 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

