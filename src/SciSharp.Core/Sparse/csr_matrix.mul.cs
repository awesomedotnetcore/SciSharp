using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class csr_matrix
    {
        public static Matrix operator *(csr_matrix m1, Matrix m2)
        {
            var np = new NumPy();

            m1.transpose();
            var (M, N) = m1.shape.BiShape;

            var result = np.zeros(M);

            csc_matvec(M, N, m1.indptr.int32, m1.indices.int32, m1.data.float64, m2.float64, result);

            return np.asmatrix(result).transpose();
        }

        public static Matrix operator *(Matrix m2, csr_matrix m1)
        {
            return m1 * m2;
        }

        private static void csc_matvec(int n_row, int n_col, int[] Ap, int[]Ai, double[] Ax, double[] Xx, NDArray Yx)
        {
            for (int j = 0; j < n_col; j++)
            {
                int col_start = Ap[j];
                int col_end = Ap[j + 1];

                for (int ii = col_start; ii < col_end; ii++)
                {
                    int i = Ai[ii];
                    Yx.float64[i] += Ax[ii] * Xx[j];
                }
            }
        }
    }
}
