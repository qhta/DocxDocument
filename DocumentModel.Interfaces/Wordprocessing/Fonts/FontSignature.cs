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
  public IHexInt UnicodeSignature0 { get => Items[0]; set => Items[0] = value; }
  /// <summary>
  ///   Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb1")]
  public IHexInt UnicodeSignature1 { get => Items[1]; set => Items[1] = value; }
  /// <summary>
  ///   Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb2")]
  public IHexInt UnicodeSignature2 { get => Items[2]; set => Items[2] = value; }
  /// <summary>
  ///   Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [XmlAttribute("usb3")]
  public IHexInt UnicodeSignature3 { get => Items[3]; set => Items[3] = value; }
  /// <summary>
  ///   Lower 32 Bits of Code Page Bit Field
  /// </summary>
  [XmlAttribute("csb0")]
  public IHexInt CodePageSignature0 { get => Items[4]; set => Items[4] = value; }
  /// <summary>
  ///   Upper 32 Bits of Code Page Bit Field
  /// </summary>
  [XmlAttribute("csb1")]
  public IHexInt CodePageSignature1 { get => Items[5]; set => Items[5] = value; }
  /// <summary>
  /// Items collecting 6 parts
  /// </summary>
  [XmlIgnore]
  public IHexInt[] Items { get; } = new IHexInt[6];
}