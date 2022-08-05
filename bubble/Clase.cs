using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    public class Clase
    {
        public List<int> Ordenar(List<int> lista) 
        {
            if(lista.Count<2)
                return lista;
            int size = lista.Count;

            int[] nums = lista.ToArray();

            for (int x=1; x<size;x++)
            {
                for (int y=0;y<size-1;y++)
                {
                    if (nums[x] < nums[y])
                    {
                        int m = nums[x];
                        nums[x] = nums[y];
                        nums[y] = m;
                    }
                }
            }

            return nums.ToList();

        }
    }
}
