namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents language codes for spell checking and grammar checking in different script contexts in WordprocessingML documents.
/// This class defines language codes for Latin/ASCII, East Asian, and complex script (bidirectional) text, supporting RFC 1766 or ISO 639 standards (e.g., "en-US", "ja-JP", "ar-SA").
/// Used to determine dictionaries, hyphenation, sorting, and theme font mapping for text runs and theme font languages.
/// </summary>
[OpenXmlType(typeof(DXW.LanguageType))]
public partial class LanguageType : ModelElement<DXW.LanguageType>
{
 /// <summary>
 /// Language code for Latin/ASCII text, typically Western European languages. Used for spell checking, grammar, and theme font mapping (major/minor Ascii/HAnsi).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.LanguageType.Val))]
 public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

 private string? _Val;
 /// <summary>
 /// Language code for East Asian text (Chinese, Japanese, Korean, etc.). Used for spell checking, grammar, and theme font mapping (major/minor EastAsia).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.LanguageType.EastAsia))]
 public string? EastAsia { get => _EastAsia; set => UpdateField(ref _EastAsia, value, nameof(EastAsia)); }

 private string? _EastAsia;
 /// <summary>
 /// Language code for complex script (bidirectional) text (Arabic, Hebrew, Thai, etc.). Used for spell checking, grammar, and theme font mapping (major/minor Bidi).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.LanguageType.Bidi))]
 public string? Bidi { get => _Bidi; set => UpdateField(ref _Bidi, value, nameof(Bidi)); }

 private string? _Bidi;
}