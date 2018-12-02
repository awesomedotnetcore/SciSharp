using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class csr_matrix
    {
        public void sort_indices()
        {

            has_sorted_indices = true;
        }
    }
}
