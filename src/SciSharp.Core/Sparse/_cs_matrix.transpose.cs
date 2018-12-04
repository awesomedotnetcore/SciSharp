using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class _cs_matrix
    {
        public _cs_matrix transpose()
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
