using System;
namespace ton_discusson_example
{
    /// <summary>
    /// Base class to implement functionality of image NFT
    /// </summary>
    public abstract class NftImageBase : NftBase, INftImage
    {
        /// <summary>
        /// Get the format of the image
        /// </summary>
        public ImageFormatTypes ImageFormat { get; }

        /// <summary>
        /// Custom viewer address, if image is some specific custom type
        /// </summary>
        public abstract string ViewerAddress { get; }

        public NftImageBase(byte[] address, TokenOwner owner, TokenType type, ImageFormatTypes imageFormat, byte[] payload, byte[] payloadHash)
            : base(address, owner, type, payload, payloadHash)
        {
            ImageFormat = imageFormat;
        }

    }
}
