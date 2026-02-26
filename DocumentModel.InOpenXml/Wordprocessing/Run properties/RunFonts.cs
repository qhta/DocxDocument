namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents font selection and theme font mapping for a text run in WordprocessingML documents.
/// This class enables specification of font names and theme fonts for ASCII, High ANSI, East Asian, and complex script character ranges, as well as font type hints for advanced font selection and rendering.
/// </summary>
public partial class RunFonts : ModelElement<DXW.RunFonts>
{
 /// <summary>
 /// Font content type hint, specifying the intended use or type of the font (e.g., default, East Asian, complex script).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.Hint))]
 public FontTypeHint? Hint { get => _Hint; set => UpdateField(ref _Hint, value, nameof(Hint)); }

 private FontTypeHint? _Hint;
 /// <summary>
 /// Font information for ASCII characters (first 128 Unicode code points).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.Ascii))]
 public String? Ascii { get => _Ascii; set => UpdateField(ref _Ascii, value, nameof(Ascii)); }

 private String? _Ascii;
 /// <summary>
 /// Font information for High ANSI characters (extended Latin and other Western scripts).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.HighAnsi))]
 public String? HighAnsi { get => _highAnsi; set => UpdateField(ref _highAnsi, value, nameof(HighAnsi)); }

 private String? _highAnsi;
 /// <summary>
 /// Font information for East Asian characters (Chinese, Japanese, Korean, etc.).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.EastAsia))]
 public String? EastAsia { get => _EastAsia; set => UpdateField(ref _EastAsia, value, nameof(EastAsia)); }

 private String? _EastAsia;
 /// <summary>
 /// Font information for complex script characters (Arabic, Hebrew, Thai, etc.).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.ComplexScript))]
 public String? ComplexScript { get => _ComplexScript; set => UpdateField(ref _ComplexScript, value, nameof(ComplexScript)); }

 private String? _ComplexScript;
 /// <summary>
 /// Theme font for ASCII characters, enabling theme-based font selection for ASCII text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.AsciiTheme))]
 public ThemeFont? AsciiTheme { get => _AsciiTheme; set => UpdateField(ref _AsciiTheme, value, nameof(AsciiTheme)); }

 private ThemeFont? _AsciiTheme;
 /// <summary>
 /// Theme font for High ANSI characters, enabling theme-based font selection for extended Latin and Western scripts.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.HighAnsiTheme))]
 public ThemeFont? HighAnsiTheme { get => _HighAnsiTheme; set => UpdateField(ref _HighAnsiTheme, value, nameof(HighAnsiTheme)); }

 private ThemeFont? _HighAnsiTheme;
 /// <summary>
 /// Theme font for East Asian characters, enabling theme-based font selection for CJK scripts.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.EastAsiaTheme))]
 public ThemeFont? EastAsiaTheme { get => _EastAsiaTheme; set => UpdateField(ref _EastAsiaTheme, value, nameof(EastAsiaTheme)); }

 private ThemeFont? _EastAsiaTheme;
 /// <summary>
 /// Theme font for complex script characters, enabling theme-based font selection for bidirectional and complex scripts.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.RunFonts.ComplexScriptTheme))]
 public ThemeFont? ComplexScriptTheme { get => _ComplexScriptTheme; set => UpdateField(ref _ComplexScriptTheme, value, nameof(ComplexScriptTheme)); }

 private ThemeFont? _ComplexScriptTheme;
}