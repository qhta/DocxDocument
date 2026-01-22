namespace DocumentModel.Drawings;
/// <summary>
///   Represents font settings for text, including typeface, Panose classification, pitch family, and character set.
/// </summary>
public partial class TextFontType : ModelElement
{
    /// <summary>
    ///   Typeface name for the font.
    /// </summary>
    public string? Typeface { get => _Typeface; set => UpdateField(ref _Typeface, value, nameof(Typeface)); }

    private string? _Typeface;
    /// <summary>
    ///   Panose classification for the font.
    /// </summary>
    public HexBinary? Panose { get; set; }
    /// <summary>
    ///   Pitch family value indicating similar font family.
    /// </summary>
    public SByte? PitchFamily { get; set; }
    /// <summary>
    ///   Character set value indicating similar character set.
    /// </summary>
    public SByte? CharacterSet { get; set; }
}