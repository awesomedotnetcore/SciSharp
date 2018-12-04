using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class _cs_matrix
    {
        public static matrix operator *(_cs_matrix m1, matrix m2)
        {
            var np = new NumPy();

            m1.transpose();
            var (M, N) = m1.shape.BiShape;

            var result = np.zeros(M);

            spmatrix.csc_matvec(M, N, m1.indptr.int32, m1.indices.int32, m1.data.float64, m2.float64, result);

            m1.transpose();
            return np.asmatrix(result).transpose();
        }

        public static matrix operator *(matrix m2, _cs_matrix m1)
        {
            return m1 * m2;
        }
    }
}
