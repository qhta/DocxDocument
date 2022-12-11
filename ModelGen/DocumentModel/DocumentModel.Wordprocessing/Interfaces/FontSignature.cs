namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public interface FontSignature
{
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature0 { get ; set; }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature1 { get ; set; }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature2 { get ; set; }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature3 { get ; set; }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public HexBinaryValue? CodePageSignature0 { get ; set; }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public HexBinaryValue? CodePageSignature1 { get ; set; }
  
}
