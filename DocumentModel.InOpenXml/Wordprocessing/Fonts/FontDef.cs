namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the properties for a font used in a WordprocessingML document.
/// A font element is written for each font face used in the document and includes the font name, optional font metrics for substitution, and optional embedded font forms.
/// </summary>
[OpenXmlType(typeof(DXW.Font))]
public partial class FontDef : ModelElement<DXW.Font>
{
 /// <summary>
 /// Primary name of the font, used to link font information with uses in the rFonts element in document content.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.Name))]
 public string? FontName { get => _fontName; set => UpdateField(ref _fontName, value, nameof(FontName)); }

 private string? _fontName;
 /// <summary>
 /// Set of alternative names for the font, stored as a comma-delimited list, used to locate the font if the primary name is unavailable.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.AltName))]
 public StringList? Aliases { get => _Aliases; set => UpdateField(ref _Aliases, value, nameof(Aliases)); }

 private StringList? _Aliases;
 /// <summary>
 /// Panose-1 classification number, used for font substitution logic to locate appropriate substitute fonts.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.Panose1Number))]
 public HexBinary? Panose { get => _Panose; set => UpdateField(ref _Panose, value, nameof(Panose)); }

 private HexBinary? _Panose;
 /// <summary>
 /// Character set supported by the font, used for font substitution logic.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.FontCharSet))]
 public FontCharset? Charset { get => _charset; set => UpdateField(ref _charset, value, nameof(Charset)); }

 private FontCharset? _charset;
 /// <summary>
 /// Font family classification (e.g., Roman, Swiss, Modern).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.FontFamily))]
 public FontFamily? FontFamily { get => _FontFamily; set => UpdateField(ref _FontFamily, value, nameof(FontFamily)); }

 private FontFamily? _FontFamily;
 /// <summary>
 /// Indicates whether the font is not a TrueType font.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.NotTrueType))]
 public bool? NotTrueType { get => _NotTrueType; set => UpdateField(ref _NotTrueType, value, nameof(NotTrueType)); }

 private bool? _NotTrueType;
 /// <summary>
 /// Pitch of the font (e.g., fixed, variable).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.Pitch))]
 public FontPitch? Pitch { get => _Pitch; set => UpdateField(ref _Pitch, value, nameof(Pitch)); }

 private FontPitch? _Pitch;
 /// <summary>
 /// Font signature information, including Unicode subset and code page bitfields.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.FontSignature))]
 [OpenXmlLoadData(nameof(LoadFontSignatureFromOpenXml))]
 [OpenXmlUpdateData(nameof(UpdateFontSignatureToOpenXml))]
 public HexBinary? FontSignature { get => _FontSignature; set => UpdateField(ref _FontSignature, value, nameof(FontSignature)); }

 private HexBinary? _FontSignature;
 private void LoadFontSignatureFromOpenXml(object openXmlElement)
 {
  var openXmlFont = (DXW.Font)openXmlElement;
  var openXmlFontSignature = openXmlFont.FontSignature;
  if (openXmlFontSignature == null)
   return;
  var str = openXmlFontSignature.UnicodeSignature0?.ToString() + openXmlFontSignature.UnicodeSignature1?.ToString() + openXmlFontSignature.UnicodeSignature2?.ToString() + openXmlFontSignature.UnicodeSignature3?.ToString() + openXmlFontSignature.CodePageSignature0?.ToString() + openXmlFontSignature.CodePageSignature1?.ToString();
  FontSignature = new HexBinary(str);
 }

 private void UpdateFontSignatureToOpenXml(object openXmlElement)
 {
  var openXmlFont = (DXW.Font)openXmlElement;
  if (FontSignature == null)
   return;
  var hexStr = FontSignature.ToString();
  if (hexStr.Length < 32)
   throw new InvalidOperationException("FontSignature HexBinary value is too short");
  openXmlFont.FontSignature = new DXW.FontSignature
  {
   UnicodeSignature0 = new DX.HexBinaryValue(hexStr.Substring(0, 8)),
   UnicodeSignature1 = new DX.HexBinaryValue(hexStr.Substring(8, 8)),
   UnicodeSignature2 = new DX.HexBinaryValue(hexStr.Substring(16, 8)),
   UnicodeSignature3 = new DX.HexBinaryValue(hexStr.Substring(24, 8)),
   CodePageSignature0 = new DX.HexBinaryValue(hexStr.Substring(32, 8)),
   CodePageSignature1 = new DX.HexBinaryValue(hexStr.Substring(40, 8)),
  };
 }
}