using System;
namespace ton_discusson_example
{
    /// <summary>
    /// Enumeration describint the type of token
    /// Some kind of standart types should be developed by community. Something like media-type
    /// </summary>
    public enum TokenType : ushort
    {
        Unknown = 0,
        Generic = 1,
        Image = 2,
        AnimationImage = 3,
        Image3D = 4,
        Animation3D = 5,
        Movie = 6,
        GenericDocument = 7,
        NotaryDocument = 8,
        ScriptingDocumant = 9,
        StakingVoucher =10,
        BettingVoucher = 11,
        RewardVoucher = 12,
        WinVoucher = 13
        // etc...
    }
}
