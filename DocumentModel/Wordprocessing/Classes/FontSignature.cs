namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontSignature Class.
/// </summary>
public class FontSignature
{
  /// <summary>
  ///   First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb0")]
  public HexInt? UnicodeSignature0 { get; set; }

  /// <summary>
  ///   Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb1")]
  public HexInt? UnicodeSignature1 { get; set; }

  /// <summary>
  ///   Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb2")]
  public HexInt? UnicodeSignature2 { get; set; }

  /// <summary>
  ///   Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb3")]
  public HexInt? UnicodeSignature3 { get; set; }

  /// <summary>
  ///   Lower 32 Bits of Code Page Bit Field
  /// </summary>
  [XmlAttribute("csb0")]
  public HexInt? CodePageSignature0 { get; set; }

  /// <summary>
  ///   Upper 32 Bits of Code Page Bit Field
  /// </summary>
  [XmlAttribute("csb1")]
  public HexInt? CodePageSignature1 { get; set; }
}