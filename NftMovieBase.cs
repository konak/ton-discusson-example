using System;
namespace ton_discusson_example
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class NftMovieBase : NftBase, INftMovie
    {
        /// <summary>
        /// Get the format of the movie
        /// </summary>
        public MovieFormatTypes MovieFormat { get; }

        /// <summary>
        /// Recommended codec of the move
        /// </summary>
        public abstract string Codec { get; }

        /// <summary>
        /// Custom viewer address, if movie was encoded with some specific codec
        /// </summary>
        public abstract string ViewerAddress { get; }

        public NftMovieBase(byte[] address, TokenOwner owner, TokenType type, MovieFormatTypes movieFormat, byte[] payload, uint payloadSize, byte[] payloadHash)
            : base(address, owner, type, payload, payloadSize, payloadHash)
        {
            MovieFormat = movieFormat;
        }


    }
}
