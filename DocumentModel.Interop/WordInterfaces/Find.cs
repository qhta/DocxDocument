namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the criteria for a find operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find?view=word-pia"/>
public partial interface Find : InteropObject
{
  /// <summary>
  /// The forward.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.forward?view=word-pia"/>
  public bool Forward { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// The found.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.found?view=word-pia"/>
  public bool Found { get; }

  /// <summary>
  /// The match all word forms.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchallwordforms?view=word-pia"/>
  public bool MatchAllWordForms { get; set; }

  /// <summary>
  /// The match case.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchcase?view=word-pia"/>
  public bool MatchCase { get; set; }

  /// <summary>
  /// The match wildcards.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchwildcards?view=word-pia"/>
  public bool MatchWildcards { get; set; }

  /// <summary>
  /// The match sounds like.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchsoundslike?view=word-pia"/>
  public bool MatchSoundsLike { get; set; }

  /// <summary>
  /// The match whole word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchwholeword?view=word-pia"/>
  public bool MatchWholeWord { get; set; }

  /// <summary>
  /// The match fuzzy.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchfuzzy?view=word-pia"/>
  public bool MatchFuzzy { get; set; }

  /// <summary>
  /// The match byte.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchbyte?view=word-pia"/>
  public bool MatchByte { get; set; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The language id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The highlight.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.highlight?view=word-pia"/>
  public int Highlight { get; set; }

  /// <summary>
  /// The replacement.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.replacement?view=word-pia"/>
  public Replacement Replacement { get; }

  /// <summary>
  /// The frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.frame?view=word-pia"/>
  public Frame Frame { get; }

  /// <summary>
  /// The wrap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.wrap?view=word-pia"/>
  public WdFindWrap Wrap { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.format?view=word-pia"/>
  public bool Format { get; set; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageidother?view=word-pia"/>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The correct hangul endings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.correcthangulendings?view=word-pia"/>
  public bool CorrectHangulEndings { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// The match kashida.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchkashida?view=word-pia"/>
  public bool MatchKashida { get; set; }

  /// <summary>
  /// The match diacritics.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchdiacritics?view=word-pia"/>
  public bool MatchDiacritics { get; set; }

  /// <summary>
  /// The match alef hamza.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchalefhamza?view=word-pia"/>
  public bool MatchAlefHamza { get; set; }

  /// <summary>
  /// The match control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchcontrol?view=word-pia"/>
  public bool MatchControl { get; set; }

  /// <summary>
  /// The match phrase.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchphrase?view=word-pia"/>
  public bool MatchPhrase { get; set; }

  /// <summary>
  /// The match prefix.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchprefix?view=word-pia"/>
  public bool MatchPrefix { get; set; }

  /// <summary>
  /// The match suffix.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchsuffix?view=word-pia"/>
  public bool MatchSuffix { get; set; }

  /// <summary>
  /// The ignore space.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.ignorespace?view=word-pia"/>
  public bool IgnoreSpace { get; set; }

  /// <summary>
  /// The ignore punct.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.ignorepunct?view=word-pia"/>
  public bool IgnorePunct { get; set; }

  /// <summary>
  /// The hanja phonetic hangul.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.hanjaphonetichangul?view=word-pia"/>
  public bool HanjaPhoneticHangul { get; set; }
}
