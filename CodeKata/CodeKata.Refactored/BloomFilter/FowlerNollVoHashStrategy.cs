namespace CodeKata.Refactored.BloomFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Fowler–Noll–Vo hash function - https://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
    /// </summary>
    public class FowlerNollVoHashStrategy : NonCriptographyHashStrategy
    {
        public override UInt64 GetHash(string str)
        {
            return this.GetFNVHash(str);
        }

        private UInt64 GetFNVHash(string s)
        {
            //FNV_offset_basis
            UInt64 fnvOffsetBasis = 14695981039346656037;

            //FNV prime
            UInt64 fnvPrime = 1099511628211;

            byte[] valueToHash = Encoding.UTF8.GetBytes(s);
            foreach (byte actualByte in valueToHash)
            {
                unchecked
                {
                    fnvOffsetBasis ^= actualByte;
                    fnvOffsetBasis *= fnvPrime;
                }
            }

            return fnvOffsetBasis;
        }
    }
}
