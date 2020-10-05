﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DiffFilterTest
    {
        [Test]
        public void DiffFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = DiffFilter.Diff(input);
            int[] expected = { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5 };

            CollectionAssert.AreEqual(expected, output);
        }

    }
}
