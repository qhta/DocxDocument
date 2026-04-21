namespace DocumentModel.Drawings;
/// <summary>
///   Represents font settings for text, including typeface, Panose classification, pitch family, and character set.
/// </summary>
[OpenXmlType(typeof(DXD.TextFontType))]
[XmlRoot("TextFontType", Namespace = "DocumentModel.Drawings")]
public partial class TextFontType : ModelElement<DXD.TextFontType>
{
 /// <summary>
 ///   Typeface name for the font.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TextFontType.Typeface))]
 public string? Typeface { get => _Typeface; set => UpdateField(ref _Typeface, value, nameof(Typeface)); }
 private string? _Typeface;

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
 public HexByte? PitchFamily { get => _PitchFamily; set => UpdateField(ref _PitchFamily, value, nameof(PitchFamily)); }
 private HexByte? _PitchFamily;

 /// <summary>
 ///   Character set value indicating similar character set.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TextFontType.CharacterSet))]
 public HexByte? Charset { get => _charset; set => UpdateField(ref _charset, value, nameof(Charset)); }
 private HexByte? _charset;
}