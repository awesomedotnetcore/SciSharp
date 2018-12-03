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
            data = data.transpose();

            return this;
        }
    }
}
