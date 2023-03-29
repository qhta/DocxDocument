namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontSignature Class.
/// </summary>
[TypeConverter(typeof(FontSignatureTypeConverter))]
public record FontSignature
{
  /// <summary>
  ///   First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb0")]
  public HexInt UnicodeSignature0 { get => Items[0]; set => Items[0] = value; }

  /// <summary>
  ///   Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb1")]
  public HexInt UnicodeSignature1 { get => Items[1]; set => Items[1] = value; }

  /// <summary>
  ///   Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb2")]
  public HexInt UnicodeSignature2 { get => Items[2]; set => Items[2] = value; }

  /// <summary>
  ///   Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb3")]
  public HexInt UnicodeSignature3 { get => Items[3]; set => Items[3] = value; }

  /// <summary>
  ///   Lower 32 Bits of Code Page Bit Field
  /// </summary>
  [XmlAttribute("csb0")]
  public HexInt CodePageSignature0 { get => Items[4]; set => Items[4] = value; }

  /// <summary>
  ///   Upper 32 Bits of Code Page Bit Field
  /// </summary>
  [XmlAttribute("csb1")]
  public HexInt CodePageSignature1 { get => Items[5]; set => Items[5] = value; }

  /// <summary>
  /// Items collecting 6 parts
  /// </summary>
  [XmlIgnore]
  public HexInt[] Items { get; } = new HexInt[6];
}