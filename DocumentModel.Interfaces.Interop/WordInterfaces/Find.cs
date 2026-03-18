namespace DocumentModel.Interop;

/// <summary>
/// Represents the criteria for a find operation.
/// </summary>
public partial interface Find : InteropObject
{
  /// <summary>
  /// The forward.
  /// </summary>
  public bool Forward { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  public Font Font { get; set; }

  /// <summary>
  /// The found.
  /// </summary>
  public bool Found { get; }

  /// <summary>
  /// The match all word forms.
  /// </summary>
  public bool MatchAllWordForms { get; set; }

  /// <summary>
  /// The match case.
  /// </summary>
  public bool MatchCase { get; set; }

  /// <summary>
  /// The match wildcards.
  /// </summary>
  public bool MatchWildcards { get; set; }

  /// <summary>
  /// The match sounds like.
  /// </summary>
  public bool MatchSoundsLike { get; set; }

  /// <summary>
  /// The match whole word.
  /// </summary>
  public bool MatchWholeWord { get; set; }

  /// <summary>
  /// The match fuzzy.
  /// </summary>
  public bool MatchFuzzy { get; set; }

  /// <summary>
  /// The match byte.
  /// </summary>
  public bool MatchByte { get; set; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  public object Style { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The language id.
  /// </summary>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The highlight.
  /// </summary>
  public int Highlight { get; set; }

  /// <summary>
  /// The replacement.
  /// </summary>
  public Replacement Replacement { get; }

  /// <summary>
  /// The frame.
  /// </summary>
  public Frame Frame { get; }

  /// <summary>
  /// The wrap.
  /// </summary>
  public WdFindWrap Wrap { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public bool Format { get; set; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The correct hangul endings.
  /// </summary>
  public bool CorrectHangulEndings { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  public int NoProofing { get; set; }

  /// <summary>
  /// The match kashida.
  /// </summary>
  public bool MatchKashida { get; set; }

  /// <summary>
  /// The match diacritics.
  /// </summary>
  public bool MatchDiacritics { get; set; }

  /// <summary>
  /// The match alef hamza.
  /// </summary>
  public bool MatchAlefHamza { get; set; }

  /// <summary>
  /// The match control.
  /// </summary>
  public bool MatchControl { get; set; }

  /// <summary>
  /// The match phrase.
  /// </summary>
  public bool MatchPhrase { get; set; }

  /// <summary>
  /// The match prefix.
  /// </summary>
  public bool MatchPrefix { get; set; }

  /// <summary>
  /// The match suffix.
  /// </summary>
  public bool MatchSuffix { get; set; }

  /// <summary>
  /// The ignore space.
  /// </summary>
  public bool IgnoreSpace { get; set; }

  /// <summary>
  /// The ignore punct.
  /// </summary>
  public bool IgnorePunct { get; set; }

  /// <summary>
  /// The hanja phonetic hangul.
  /// </summary>
  public bool HanjaPhoneticHangul { get; set; }
}
