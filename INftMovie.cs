using System;
namespace ton_discusson_example
{
    public interface INftMovie
    {
        /// <summary>
        /// Get the format of the movie
        /// </summary>
        public MovieFormatTypes MovieFormat { get; }

        /// <summary>
        /// Recommended codec of the move
        /// </summary>
        public string Codec { get; }

        /// <summary>
        /// Custom viewer address, if movie was encoded with some specific codec
        /// </summary>
        public string ViewerAddress { get; }
    }
}
