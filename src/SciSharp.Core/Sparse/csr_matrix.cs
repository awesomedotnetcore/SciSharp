using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class csr_matrix : _cs_matrix
    {
        public csr_matrix(NDArray data, NDArray indices, NDArray indptr, Shape shape = null, Type dtype = null)
        {
            maxprint = 50;
            format = "csf";

            this.data = data;
            this.indices = indices;
            this.indptr = indptr;

            if(shape != null)
            {
                data.reshape(shape);
            }

            if(dtype != null)
            {
                data.Storage.dtype = dtype;
            }
        }
    }
}
