using System;
namespace ton_discusson_example
{
    public interface INft
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
        /// Address of the token
        /// </summary>
        public string AddressString { get; }

        /// <summary>
        /// Address data of token
        /// </summary>
        public byte[] Address { get; }

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
        public string PayloadHashString { get; }

        /// <summary>
        /// Hashcode of the payload of the token
        /// </summary>
        public byte[] PayloadHash { get; }
    }
}
