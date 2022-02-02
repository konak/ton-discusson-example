using System;
namespace ton_discusson_example
{
    public interface INftImage
    {
        /// <summary>
        /// Get the format of the image
        /// </summary>
        public ImageFormatTypes ImageFormat { get; }

        /// <summary>
        /// Custom viewer address, if image is some specific custom type
        /// </summary>
        public string ViewerAddress { get; }
    }
}
