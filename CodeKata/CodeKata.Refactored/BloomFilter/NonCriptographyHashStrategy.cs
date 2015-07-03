using System;
namespace CodeKata.Refactored.BloomFilter
{
    /// <summary>
    ///
    /// </summary>
    public abstract class NonCriptographyHashStrategy
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public abstract UInt64 GetHash(string str);
    }
}