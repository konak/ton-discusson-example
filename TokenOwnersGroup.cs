using System;
namespace ton_discusson_example
{
    /// <summary>
    /// Class to manage functionality for token owners group
    /// </summary>
    public class TokenOwnersGroup : TokenOwner
    {
        /// <summary>
        /// Create instanceof token owners group
        /// </summary>
        /// <param name="address">address data of multisignature wallet of the group</param>
        public TokenOwnersGroup(byte[] address) : base(address)
        {
        }
    }
}
