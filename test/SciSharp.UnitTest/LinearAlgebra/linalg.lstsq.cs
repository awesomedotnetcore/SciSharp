using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSharp.Core;
using SciSharp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.UnitTest.LinearAlgebra
{
    [TestClass]
    public class linalg
    {
        SciPy sp = new SciPy();

        /// <summary>
        /// fit a quadratic polynomial of the form y = a + b*x**2 to this data.
        /// </summary>
        [TestMethod]
        public void lstsq()
        {
            var x = np.array(new double[] { 1, 2.5, 3.5, 4, 5, 7, 8.5 });
            var y = np.array(new double[] { 0.3, 1.1, 1.5, 2.0, 3.2, 6.6, 8.6 });

            sp.linalg.lstsq();
        }
    }
}
