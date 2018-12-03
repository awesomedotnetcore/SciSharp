using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharp.Core.Sparse
{
    public partial class csr_matrix
    {
        public void sort_indices()
        {
            int indptrstart = 0;
            int indptrend = 0;
            int tmpindicesvalue = 0;
            double tmpdatavalue = 0;

            for (int i = 1; i < indptr.size; i++)
            {
                indptrend = indptr.int32[i] - 1;

                for (int j = indptrstart; j < indptrend; j++)
                {
                    
                    if (indices.int32[j + 1] < indices.int32[j])
                    {
                        // switch indices
                        tmpindicesvalue = indices.int32[j];
                        indices.int32[j] = indices.int32[j + 1];
                        indices.int32[j + 1] = tmpindicesvalue;

                        // switch value
                        tmpdatavalue = data.float64[j];
                        data.float64[j] = data.float64[j + 1];
                        data.float64[j + 1] = tmpdatavalue;
                    }
                }

                indptrstart = indptr.int32[i];
            }

            has_sorted_indices = true;
        }
    }
}
