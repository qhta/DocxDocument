namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public partial class FontSignature
{
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public Byte[]? UnicodeSignature0 { get; set; }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public Byte[]? UnicodeSignature1 { get; set; }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public Byte[]? UnicodeSignature2 { get; set; }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public Byte[]? UnicodeSignature3 { get; set; }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public Byte[]? CodePageSignature0 { get; set; }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public Byte[]? CodePageSignature1 { get; set; }
  
}
