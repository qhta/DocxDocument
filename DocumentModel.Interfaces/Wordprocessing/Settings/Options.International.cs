using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface IOptions : IModelObject
{

  /// <summary>
  /// True if Microsoft Word adds bidirectional control characters when saving a document as a text file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addbidirectionalmarkswhensavingtextfile?view=word-pia"/>
  public bool? AddBiDirectionalMarksWhenSavingTextFile { get; set; }

  /// <summary>
  /// True if Microsoft Word adds bidirectional control characters when cutting and copying text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addcontrolcharacters?view=word-pia"/>
  public bool? AddControlCharacters { get; set; }

  /// <summary>
  /// True if Microsoft Word encloses number formats in double quotation marks (").
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.addhebdoublequote?view=word-pia"/>
  public bool? AddHebDoubleQuote { get; set; }

  /// <summary> 
  /// True if accents are retained when a French language character is changed to uppercase. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowaccenteduppercase?view=word-pia"/>
  public bool? AllowAccentedUppercase { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores auxiliary verb forms when checking spelling in a Korean language document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcombinedauxiliaryforms?view=word-pia"/>
  public bool? AllowCombinedAuxiliaryForms { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores compound nouns when checking spelling in a Korean language document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.allowcompoundnounprocessing?view=word-pia"/>
  public bool? AllowCompoundNounProcessing { get; set; }

  /// <summary> 
  /// True if Microsoft Word applies East Asian fonts to Latin text. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.applyfareastfontstoascii?view=word-pia"/>
  public bool? ApplyFarEastFontsToAscii { get; set; }

  /// <summary> 
  /// Returns or sets the mode for the Arabic spelling checker. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicmode?view=word-pia"/>
  public AraSpeller? ArabicMode { get; set; }

  /// <summary> 
  /// Returns or sets the numeral style for an Arabic language document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.arabicnumeral?view=word-pia"/>
  public ArabicNumeral? ArabicNumeral { get; set; }

  /// <summary> 
  /// Gets or sets the mode for the Brazilian Portuguese speller. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.brazilreform?view=word-pia"/>
  public PortugueseReform? BrazilReform { get; set; }

  /// <summary> 
  /// True if Microsoft Word automatically detects Hangul endings and ignores them during conversion from Hangul 
  /// to Hanja. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.checkhangulendings?view=word-pia"/>
  public bool? CheckHangulEndings { get; set; }

  /// <summary> 
  /// True if Microsoft Word converts text that is associated with an East Asian font to the appropriate font when 
  /// it opens a document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.converthighansitofareast?view=word-pia"/>
  public bool? ConvertHighAnsiToFarEast { get; set; }

  /// <summary> 
  /// True if Microsoft Word displays the most recently used words at the top of the suggestions list during 
  /// conversion between Hangul and Hanja. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablehangulhanjarecentordering?view=word-pia"/>
  public bool? EnableHangulHanjaRecentOrdering { get; set; }

  /// <summary> 
  /// Returns or sets aBoolean that represents whether to enable legacy IME mode. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.enablelegacyimemode?view=word-pia"/>
  public bool? EnableLegacyIMEMode { get; set; }

  /// <summary> 
  /// Returns or sets a FrenchSpeller constant that represents which spelling dictionary to use for regions of 
  /// text with language formatting set to French. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.frenchreform?view=word-pia"/>
  public FrenchSpeller? FrenchReform { get; set; }

  /// <summary> 
  /// True if Microsoft Word automatically converts a word with only one suggestion during conversion between 
  /// Hangul and Hanja. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hangulhanjafastconversion?view=word-pia"/>
  public bool? HangulHanjaFastConversion { get; set; }

  /// <summary> 
  /// Returns or sets the mode for the Hebrew spelling checker. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.hebrewmode?view=word-pia"/>
  public HebSpellStart? HebrewMode { get; set; }

  /// <summary> 
  /// True if Microsoft Word is set to automatically open and close the Japanese Input Method Editor (IME). 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.imeautomaticcontrol?view=word-pia"/>
  public bool? IMEAutomaticControl { get; set; }

  /// <summary> 
  /// True if Microsoft Word displays an unconfirmed character string in the Japanese Input Method Editor (IME) as 
  /// an insertion between existing (confirmed) character strings. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.inlineconversion?view=word-pia"/>
  public bool? InlineConversion { get; set; }

  /// <summary> 
  /// Returns or sets the high-ANSI text interpretation behavior. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.interprethighansi?view=word-pia"/>
  public HighAnsiText? InterpretHighAnsi { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between the "a" and "ya" characters following the "i"-row and 
  /// "e"-row characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyay?view=word-pia"/>
  public bool? MatchFuzzyAY { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between the "ba" and "vua" characters and between the "ha" 
  /// and "fua" characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybv?view=word-pia"/>
  public bool? MatchFuzzyBV { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between full-width and half-width characters (Latin or 
  /// Japanese) during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzybyte?view=word-pia"/>
  public bool? MatchFuzzyByte { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between uppercase and lowercase letters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzycase?view=word-pia"/>
  public bool? MatchFuzzyCase { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between minus signs, long vowel sounds, and dashes during a 
  /// search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydash?view=word-pia"/>
  public bool? MatchFuzzyDash { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between the "di" and "zi" characters and between the "du" and 
  /// "zu" characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzydz?view=word-pia"/>
  public bool? MatchFuzzyDZ { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction the "heyu" and "fuyu" characters and between the "beyu" and 
  /// "vuyu" characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhf?view=word-pia"/>
  public bool? MatchFuzzyHF { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between hiragana and katakana during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyhiragana?view=word-pia"/>
  public bool? MatchFuzzyHiragana { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between types of repetition marks during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyiterationmark?view=word-pia"/>
  public bool? MatchFuzzyIterationMark { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between standard and nonstandard kanji ideography during a 
  /// search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykanji?view=word-pia"/>
  public bool? MatchFuzzyKanji { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between the "ki" and "ku" characters before "sa"- row 
  /// characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzykiku?view=word-pia"/>
  public bool? MatchFuzzyKiKu { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between new kana and old kana characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyoldkana?view=word-pia"/>
  public bool? MatchFuzzyOldKana { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between short and long vowel sounds during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyprolongedsoundmark?view=word-pia"/>
  public bool? MatchFuzzyProlongedSoundMark { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between types of punctuation marks during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzypunctuation?view=word-pia"/>
  public bool? MatchFuzzyPunctuation { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between diphthongs and double consonants during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzysmallkana?view=word-pia"/>
  public bool? MatchFuzzySmallKana { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between space markers used during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyspace?view=word-pia"/>
  public bool? MatchFuzzySpace { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction between the "tsui", "tei", and "chi" characters and between 
  /// the "dei" and "ji" characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzytc?view=word-pia"/>
  public bool? MatchFuzzyTC { get; set; }

  /// <summary> 
  /// True if Microsoft Word ignores the distinction the "se" and "shie" characters and between the "ze" and "jie" 
  /// characters during a search. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.matchfuzzyzj?view=word-pia"/>
  public bool? MatchFuzzyZJ { get; set; }

  /// <summary> 
  /// Returns or sets the direction for conversion between Hangul and Hanja. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.monthnames?view=word-pia"/>
  public MonthNames? MonthNames { get; set; }

  /// <summary> 
  /// Returns or sets the direction for conversion between Hangul and Hanja. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.multiplewordconversionsmode?view=word-pia"/>
  public MultipleWordConversionsMode? MultipleWordConversionsMode { get; set; }

  /// <summary> 
  /// Gets or sets the mode for the European Portuguese speller. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.portugalreform?view=word-pia"/>
  public PortugueseReform? PortugalReform { get; set; }

  /// <summary> 
  /// True to check the sequence of independent characters for South Asian text. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.sequencecheck?view=word-pia"/>
  public bool? SequenceCheck { get; set; }

  /// <summary> 
  /// Gets or sets the mode for the Spanish speller. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.spanishmode?view=word-pia"/>
  public SpanishSpeller? SpanishMode { get; set; }

  /// <summary> 
  /// True if the spelling checker uses spelling rules regarding Arabic words ending with the letter yaa. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictfinalyaa?view=word-pia"/>
  public bool? StrictFinalYaa { get; set; }

  /// <summary> 
  /// True if the spelling checker uses spelling rules regarding Arabic words beginning with an alef hamza. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictinitialalefhamza?view=word-pia"/>
  public bool? StrictInitialAlefHamza { get; set; }

  /// <summary> 
  /// Gets or sets whether the spelling checker uses spelling rules regarding Russian words that use the strict ë 
  /// character. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.strictrussiane?view=word-pia"/>
  public bool? StrictRussianE { get; set; }

  /// <summary> 
  /// Gets or sets whether the spelling checker uses spelling rules to flag Arabic words ending with haa instead 
  /// of taa marboota. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.stricttaamarboota?view=word-pia"/>
  public bool? StrictTaaMarboota { get; set; }

  /// <summary> 
  /// True if Microsoft Word uses the German post-reform spelling rules when checking spelling. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usegermanspellingreform?view=word-pia"/>
  public bool? UseGermanSpellingReform { get; set; }

}
