namespace DocumentModel.Drawings;
/// <summary>
///   Represents font settings for text, including typeface, Panose classification, pitch family, and character set.
/// </summary>
[OpenXmlType(typeof(DXD.TextFontType))]
[XmlRoot("TextFontType", Namespace = "DocumentModel.Drawings")]
public partial class TextFontType : ModelElement<DXD.TextFontType>
{
 /// <summary>
 ///   Name name for the font.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TextFontType.Typeface))]
 public string? Typeface { get => _typeface; set => UpdateField(ref _typeface, value, nameof(Typeface)); }
 private string? _typeface;

 /// <summary>
 ///   Panose classification for the font.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TextFontType.Panose))]
 public HexBinary? Panose { get => _Panose; set => UpdateField(ref _Panose, value, nameof(Panose)); }
 private HexBinary? _Panose;

 /// <summary>
 ///   Pitch family value indicating similar font family.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TextFontType.PitchFamily))]
 public HexByte? Pitch { get => _pitch; set => UpdateField(ref _pitch, value, nameof(Pitch)); }
 private HexByte? _pitch;

 /// <summary>
 ///   Character set value indicating similar character set.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TextFontType.CharacterSet))]
 public HexByte? Charset { get => _charset; set => UpdateField(ref _charset, value, nameof(Charset)); }
 private HexByte? _charset;
}