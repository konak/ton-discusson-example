using System;
namespace ton_discusson_example
{
    /// <summary>
    /// Wallet address, single signature or multysignature
    /// </summary>
    public class WalletAddress
    {
        internal byte[] _address;

        /// <summary>
        /// Human readable address representation
        /// </summary>
        public string Address
        {
            get
            {
                // Not the eaxact (real) implementation ... just for having something
                return BitConverter.ToString(_address);
            }
        }

        public WalletAddress(byte[] address)
        {
            _address = address;
        }
    }
}
