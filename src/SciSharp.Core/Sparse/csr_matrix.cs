using NumSharp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class csr_matrix
    {
        public NDArray data { get; set; }

        public int ndim => data.ndim;

        public Type dtype => data.dtype;

        public Shape shape => data.shape;

        public int maxprint { get; set; }

        public int nnz
        {
            get
            {
                switch (data.dtype.Name)
                {
                    case "Int32":
                        return data.Data<int>().Length;
                    case "Double":
                        return data.Data<double>().Length;
                }

                return 0;
            }
        }

        public bool has_canonical_format { get; set; }

        public bool has_sorted_indices { get; set; }

        public string format { get; }

        public NDArray indices { get; set; }

        public NDArray indptr { get; set; }

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
