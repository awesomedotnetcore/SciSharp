using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class csr_matrix
    {
        public void sum(int? axis = null)
        {
            var np = new NumPy();
            var (m, n) = shape.BiShape;

            // sum over columns
            if (axis == 0)
            {
                var matrix = np.asmatrix(np.ones(new Shape(1, m), dtype));
                var ret = matrix * this;
            }
        }
    }
}
