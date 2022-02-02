using System;
namespace ton_discusson_example
{

    /// <summary>
    /// A base class for token owner
    /// </summary>
    public class TokenOwner : WalletAddress
    {
        /// <summary>
        /// Creates instance of TokenOwner
        /// </summary>
        /// <param name="address">address data of token owner</param>
        public TokenOwner(byte[] address) : base(address)
        {
        }
    }
}
