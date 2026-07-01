// ReSharper disable SpecifyACultureInStringConversionExplicitly
namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the properties for a font used in a WordprocessingML document.
/// A font element is written for each font face used in the document and includes the font name, optional font metrics for substitution, and optional embedded font forms.
/// </summary>
[OpenXmlType(typeof(DXW.Font))]
[DataContract]
[XmlRoot("FontDef", Namespace = "DocumentModel.Wordprocessing")]
public partial class Font : ModelElement<DXW.Font>
{
 /// <summary>
 /// Primary name of the font, used to link font information with uses in the rFonts element in document content.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.Name))]
 public string? Typeface { get => _typeface; set => UpdateField(ref _typeface, value, nameof(Typeface)); }
 private string? _typeface;

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
 public HexBinary? Panose { get => _panose; set => UpdateField(ref _panose, value, nameof(Panose)); }
 private HexBinary? _panose;

 /// <summary>
 /// Character set supported by the font, used for font substitution logic.
 /// </summary>
 //[OpenXmlProperty(nameof(DXW.Font.FontCharSet))]
 [OpenXmlLoadData(nameof(LoadCharset))]
 [OpenXmlUpdateData(nameof(UpdateCharset))]
 public HexByte? Charset { get => _charset; set => UpdateField(ref _charset, value, nameof(Charset)); }
 private HexByte? _charset;

 /// <summary>
 /// TextFormat family classification (e.g., Roman, Swiss, Modern).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.FontFamily))]
 public FontFamily? FontFamily { get => _fontFamily; set => UpdateField(ref _fontFamily, value, nameof(FontFamily)); }
 private FontFamily? _fontFamily;

 /// <summary>
 /// Pitch of the font (e.g., fixed, variable).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.Pitch))]
 public FontPitch? Pitch { get => _Pitch; set => UpdateField(ref _Pitch, value, nameof(Pitch)); }
 private FontPitch? _Pitch;

 /// <summary>
 /// TextFormat signature information, including Unicode subset and code page bitfields.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.FontSignature))]
 public HexBinary? FontSignature { get => _FontSignature; set => UpdateField(ref _FontSignature, value, nameof(FontSignature)); }
 private HexBinary? _FontSignature;

 /// <summary>
 /// Indicates whether the font is not a TrueType font.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.NotTrueType))]
 public bool? NotTrueType { get => _NotTrueType; set => UpdateField(ref _NotTrueType, value, nameof(NotTrueType)); }
 private bool? _NotTrueType;

  /// <summary>
  /// Reference to an embedded font part containing the regular (non-bold, non-italic) form of the font,
  /// used for embedding font data within the document package.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Font.EmbedRegularFont))]
 public EmbedFont? EmbedRegularFont { get => _EmbedRegularFont; set => UpdateField(ref _EmbedRegularFont, value, nameof(EmbedRegularFont)); }
 private EmbedFont? _EmbedRegularFont;

 /// <summary>
 /// Reference to an embedded font part containing the bold form of the font,
 /// used for embedding font data within the document package.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.EmbedBoldFont))]
 public EmbedFont? EmbedBoldFont { get => _EmbedBoldFont; set => UpdateField(ref _EmbedBoldFont, value, nameof(EmbedBoldFont)); }
 private EmbedFont? _EmbedBoldFont;

 /// <summary>
 /// Reference to an embedded font part containing the italic form of the font,
 /// used for embedding font data within the document package.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.EmbedItalicFont))]
 public EmbedFont? EmbedItalicFont { get => _EmbedItalicFont; set => UpdateField(ref _EmbedItalicFont, value, nameof(EmbedItalicFont)); }
 private EmbedFont? _EmbedItalicFont;

 /// <summary>
 /// Reference to an embedded font part containing the bold italic form of the font,
 /// used for embedding font data within the document package.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Font.EmbedBoldItalicFont))]
 public EmbedFont? EmbedBoldItalicFont { get => _EmbedBoldItalicFont; set => UpdateField(ref _EmbedBoldItalicFont, value, nameof(EmbedBoldItalicFont)); }
 private EmbedFont? _EmbedBoldItalicFont;

 /// <summary>
 /// Loads the character set from the specified font source and updates the Charset property accordingly.
 /// </summary>
 /// <remarks>If the source provides a StrictCharacterSet, it is used to update the Charset property.
 /// Otherwise, the Val property is used. If neither is available, the Charset property remains unchanged.</remarks>
 /// <param name = "fontElement">The font source from which to load the character set. Cannot be null; if the FontCharSet property of the source is
 /// null, no action is taken.</param>
 public void LoadCharset(DXW.Font fontElement)
 {
  if (fontElement.FontCharSet == null)
   Charset = null;
  else if (fontElement.FontCharSet?.Val?.Value != null)
   Charset = new HexByte(fontElement.FontCharSet.Val!.Value!);
  else if (fontElement.FontCharSet?.StrictCharacterSet != null)
   Charset = strictCharacterSets.GetValue2(fontElement.FontCharSet.StrictCharacterSet);
  else
   Charset = null;
 }

 /// <summary>
 /// Updates the character set information of the specified font element to reflect the current charset value.
 /// </summary>
 /// <remarks>If the current charset is null, the font element's character set is cleared. If a strict
 /// character set mapping exists for the current charset, it is applied; otherwise, the charset value is assigned
 /// directly.</remarks>
 /// <param name = "fontElement">The font element whose character set will be updated. This parameter must not be null.</param>
 public void UpdateCharset(DXW.Font fontElement)
 {
  if (Charset == null)
   fontElement.FontCharSet = null;
  else
  {
   fontElement.FontCharSet = new DXW.FontCharSet()
   {
    Val = Charset.ToString("X2"),
   };
  }
 }
 private static readonly BiDiDictionary<DXW.StrictCharacterSet, string> strictCharacterSets = new BiDiDictionary<DXW.StrictCharacterSet, string>()
 {
  {
   DXW.StrictCharacterSet.chsAnsi,
   "ansi"
  },
  {
   DXW.StrictCharacterSet.chsMacFfn,
   "macintosh"
  },
  {
   DXW.StrictCharacterSet.chsShiftJIS,
   "shift_jis"
  },
  {
   DXW.StrictCharacterSet.chsHangeul,
   "ks_c-5601-1987"
  },
  {
   DXW.StrictCharacterSet.chsJohab,
   "ks_c-5601-1992"
  },
  {
   DXW.StrictCharacterSet.chsGB2312,
   "gbk"
  },
  {
   DXW.StrictCharacterSet.chsChinese5,
   "big5"
  },
  {
   DXW.StrictCharacterSet.chsGreek,
   "windows-1253"
  },
  {
   DXW.StrictCharacterSet.chsTurkish,
   "iso-8859-9"
  },
  {
   DXW.StrictCharacterSet.chsVietnamese,
   "windows-1258"
  },
  {
   DXW.StrictCharacterSet.chsHebrew,
   "windows-1255"
  },
  {
   DXW.StrictCharacterSet.chsArabic,
   "windows-1256"
  },
  {
   DXW.StrictCharacterSet.chsBaltic,
   "windows-1257"
  },
  {
   DXW.StrictCharacterSet.chsRussian,
   "windows-1251"
  },
  {
   DXW.StrictCharacterSet.chsThai,
   "windows-874"
  },
  {
   DXW.StrictCharacterSet.chsEastEurope,
   "windows-1250"
  },
 };
 private static readonly BiDiDictionary<DXW.StrictCharacterSet, byte> characterSetsCode = new BiDiDictionary<DXW.StrictCharacterSet, byte>()
 {
  {
   DXW.StrictCharacterSet.chsAnsi,
   0x00
  },
  {
   DXW.StrictCharacterSet.chsMacFfn,
   0x4D
  },
  {
   DXW.StrictCharacterSet.chsShiftJIS,
   0x80
  },
  {
   DXW.StrictCharacterSet.chsHangeul,
   0x81
  },
  {
   DXW.StrictCharacterSet.chsJohab,
   0x82
  },
  {
   DXW.StrictCharacterSet.chsGB2312,
   0x86
  },
  {
   DXW.StrictCharacterSet.chsChinese5,
   0x05
  },
  {
   DXW.StrictCharacterSet.chsGreek,
   0xA1
  },
  {
   DXW.StrictCharacterSet.chsTurkish,
   0xA2
  },
  {
   DXW.StrictCharacterSet.chsVietnamese,
   0xA3
  },
  {
   DXW.StrictCharacterSet.chsHebrew,
   0xB1
  },
  {
   DXW.StrictCharacterSet.chsArabic,
   0xB2
  },
  {
   DXW.StrictCharacterSet.chsBaltic,
   0xBA
  },
  {
   DXW.StrictCharacterSet.chsRussian,
   0xCC
  },
  {
   DXW.StrictCharacterSet.chsThai,
   0xDE
  },
  {
   DXW.StrictCharacterSet.chsEastEurope,
   0xEE
  },
 };
}