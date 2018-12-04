using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class csr_matrix
    {
        public csr_matrix transpose()
        {
            if (data.ndim == 1)
            {
                data = data.transpose();
            }
            else
            {
                data.reshape(data.shape.Shapes.Reverse().ToArray());
            }

            return this;
        }
    }
}
