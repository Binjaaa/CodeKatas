namespace CodeKata.Refactored.BloomFilter
{
    using System;

    public class JenkinsHashStrategy : NonCriptographyHashStrategy
    {
        /// <summary>
        /// Jenkins One-at-a time hash function - http://en.wikipedia.org/wiki/Jenkins_hash_function
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private UInt64 JenkinsOneAtTime(string str)
        {
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                num += str[i];
                num += num << 10;
                num ^= num >> 6;
            }
            num += num << 3;
            num ^= num >> 11;

            return Convert.ToUInt64((num + (num << 15)));
        }

        public override UInt64 GetHash(string str)
        {
            return this.JenkinsOneAtTime(str);
        }
    }
}