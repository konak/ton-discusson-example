using System;

namespace ton_discusson_example
{
    /// <summary>
    /// Base class used to implement Nft
    /// </summary>
    public abstract class NftBase : INft
    {

        /// <summary>
        /// Type of the token
        /// </summary>
        public TokenType Type { get; }

        /// <summary>
        /// Address of token owner or creator
        /// </summary>
        public TokenOwner Owner { get; }

        /// <summary>
        /// HumanReadable address of the token
        /// </summary>
        public string AddressString { get { return BitConverter.ToString(Address); } }

        /// <summary>
        /// Payload data of the token
        /// </summary>
        public byte[] Payload { get; }

        /// <summary>
        /// Size of payload data of the token
        /// </summary>
        public uint PayloadSize { get; }

        /// <summary>
        /// Hashcode of the payload of the token
        /// </summary>
        public byte[] PayloadHash { get; }

        /// <summary>
        /// Hashcode of the payload of the token
        /// </summary>
        public string PayloadHashString { get { return BitConverter.ToString(PayloadHash); } }

        /// <summary>
        /// Address data of token
        /// </summary>
        public byte[] Address { get; }

        /// <summary>
        /// Base constructor to create NFT token
        /// </summary>
        /// <param name="address"></param>
        /// <param name="owner"></param>
        /// <param name="type"></param>
        /// <param name="payload"></param>
        /// <param name="payloadHash"></param>
        public NftBase(byte[] address, TokenOwner owner, TokenType type, byte[] payload, uint payloadSize, byte[] payloadHash)
        {
            Address = address;
            Owner = owner;
            Type = type;
            Payload = payload;
            PayloadSize = payloadSize;
            PayloadHash = payloadHash;
        }


    }
}
