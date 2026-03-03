using Qhta.Collections;

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
  //[OpenXmlProperty(nameof(DXW.Font.FontCharSet))]
  [OpenXmlLoadData(nameof(LoadCharset))]
  [OpenXmlUpdateData(nameof(UpdateCharset))]
  public HexChar? Charset { get => _charset; set => UpdateField(ref _charset, value, nameof(Charset)); }

  private HexChar? _charset;

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
  public HexBinary? FontSignature
  {
    get => _FontSignature;
    set => UpdateField(ref _FontSignature, value, nameof(FontSignature));
  }

  private HexBinary? _FontSignature;

  /// <summary>
  /// Loads the character set from the specified font source and updates the Charset property accordingly.
  /// </summary>
  /// <remarks>If the source provides a StrictCharacterSet, it is used to update the Charset property.
  /// Otherwise, the Val property is used. If neither is available, the Charset property remains unchanged.</remarks>
  /// <param name="fontElement">The font source from which to load the character set. Cannot be null; if the FontCharSet property of the source is
  /// null, no action is taken.</param>
  public void LoadCharset(DXW.Font fontElement)
  {
    if (fontElement.FontCharSet == null)
      Charset = null;
    else
      Charset = /*fontElement.FontCharSet.StrictCharacterSet != null ? strictCharacterSets.GetValue1(fontElement.FontCharSet.StrictCharacterSet) :*/
        new HexChar(fontElement.FontCharSet.Val?.Value);
  }

  /// <summary>
  /// Updates the character set information of the specified font element to reflect the current charset value.
  /// </summary>
  /// <remarks>If the current charset is null, the font element's character set is cleared. If a strict
  /// character set mapping exists for the current charset, it is applied; otherwise, the charset value is assigned
  /// directly.</remarks>
  /// <param name="fontElement">The font element whose character set will be updated. This parameter must not be null.</param>
  public void UpdateCharset(DXW.Font fontElement)
  {
    if (Charset == null)
      fontElement.FontCharSet = null;
    else
    {
      //if (strictCharacterSets.TryGetValue2(Charset, out var strictCharacterSet))
      //  fontElement.FontCharSet = new DXW.FontCharSet()
      //  {
      //    StrictCharacterSet = strictCharacterSet,
      //    Val = Charset,
      //  };
      //else
        fontElement.FontCharSet = new DXW.FontCharSet()
        {
          // ReSharper disable once SpecifyACultureInStringConversionExplicitly
          Val = Charset.ToString(),
        };
    }
  }

  private static readonly BiDiDictionary<string, DXW.StrictCharacterSet> strictCharacterSets = new BiDiDictionary<string, DXW.StrictCharacterSet>() {
    { "ansi", DXW.StrictCharacterSet.chsAnsi },
    { "macintosh", DXW.StrictCharacterSet.chsMacFfn },
    { "shift_jis", DXW.StrictCharacterSet.chsShiftJIS},
    { "ks_c-5601-1987", DXW.StrictCharacterSet.chsHangeul},
    {" ks_c-5601-1992", DXW.StrictCharacterSet.chsJohab},
    { "gbk", DXW.StrictCharacterSet.chsGB2312},
    { "big5", DXW.StrictCharacterSet.chsChinese5},
    { "windows-1253", DXW.StrictCharacterSet.chsGreek},
    { "iso-8859-9", DXW.StrictCharacterSet.chsTurkish},
    { "windows-1258", DXW.StrictCharacterSet.chsVietnamese},
    { "windows-1255", DXW.StrictCharacterSet.chsHebrew},
    { "windows-1256", DXW.StrictCharacterSet.chsArabic},
    { "windows-1257", DXW.StrictCharacterSet.chsBaltic},
    { "windows-1251", DXW.StrictCharacterSet.chsRussian},
    { "windows-874", DXW.StrictCharacterSet.chsThai},
    { "windows-1250", DXW.StrictCharacterSet.chsEastEurope},
  };

}