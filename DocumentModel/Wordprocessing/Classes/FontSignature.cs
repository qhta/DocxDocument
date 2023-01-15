namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontSignature Class.
/// </summary>
public class FontSignature
{
  /// <summary>
  ///   First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public UInt32? UnicodeSignature0 { get; set; }

  /// <summary>
  ///   Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public UInt32? UnicodeSignature1 { get; set; }

  /// <summary>
  ///   Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public UInt32? UnicodeSignature2 { get; set; }

  /// <summary>
  ///   Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public UInt32? UnicodeSignature3 { get; set; }

  /// <summary>
  ///   Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public UInt32? CodePageSignature0 { get; set; }

  /// <summary>
  ///   Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public UInt32? CodePageSignature1 { get; set; }
}