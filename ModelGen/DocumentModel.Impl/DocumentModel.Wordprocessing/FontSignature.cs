namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public class FontSignature: IFontSignature
{
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public IHexBinaryValue? UnicodeSignature0
  {
    get;
    set;
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public IHexBinaryValue? UnicodeSignature1
  {
    get;
    set;
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public IHexBinaryValue? UnicodeSignature2
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public IHexBinaryValue? UnicodeSignature3
  {
    get;
    set;
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public IHexBinaryValue? CodePageSignature0
  {
    get;
    set;
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public IHexBinaryValue? CodePageSignature1
  {
    get;
    set;
  }
  
}
