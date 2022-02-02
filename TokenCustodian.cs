using System;
namespace ton_discusson_example
{
    /// <summary>
    /// Class inplementing functionality for token custodian
    /// </summary>
    public class TokenCustodian : TokenOwner
    {
        /// <summary>
        /// Create instance of token custodian
        /// </summary>
        /// <param name="address">wallet address of token custodian</param>
        public TokenCustodian(byte[] address) : base(address)
        {
        }
    }
}
