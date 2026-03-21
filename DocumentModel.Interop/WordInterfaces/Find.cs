namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the criteria for a find operation.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find?view=word-pia"/>
public partial interface Find : InteropObject
{
  /// <summary>
  /// The forward.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.forward?view=word-pia"/>
  public bool Forward { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// The found.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.found?view=word-pia"/>
  public bool Found { get; }

  /// <summary>
  /// The match all word forms.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchallwordforms?view=word-pia"/>
  public bool MatchAllWordForms { get; set; }

  /// <summary>
  /// The match case.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchcase?view=word-pia"/>
  public bool MatchCase { get; set; }

  /// <summary>
  /// The match wildcards.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchwildcards?view=word-pia"/>
  public bool MatchWildcards { get; set; }

  /// <summary>
  /// The match sounds like.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchsoundslike?view=word-pia"/>
  public bool MatchSoundsLike { get; set; }

  /// <summary>
  /// The match whole word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchwholeword?view=word-pia"/>
  public bool MatchWholeWord { get; set; }

  /// <summary>
  /// The match fuzzy.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchfuzzy?view=word-pia"/>
  public bool MatchFuzzy { get; set; }

  /// <summary>
  /// The match byte.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchbyte?view=word-pia"/>
  public bool MatchByte { get; set; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The language id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The highlight.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.highlight?view=word-pia"/>
  public int Highlight { get; set; }

  /// <summary>
  /// The replacement.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.replacement?view=word-pia"/>
  public Replacement Replacement { get; }

  /// <summary>
  /// The frame.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.frame?view=word-pia"/>
  public Frame Frame { get; }

  /// <summary>
  /// The wrap.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.wrap?view=word-pia"/>
  public WdFindWrap Wrap { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.format?view=word-pia"/>
  public bool Format { get; set; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageidother?view=word-pia"/>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The correct hangul endings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.correcthangulendings?view=word-pia"/>
  public bool CorrectHangulEndings { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// The match kashida.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchkashida?view=word-pia"/>
  public bool MatchKashida { get; set; }

  /// <summary>
  /// The match diacritics.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchdiacritics?view=word-pia"/>
  public bool MatchDiacritics { get; set; }

  /// <summary>
  /// The match alef hamza.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchalefhamza?view=word-pia"/>
  public bool MatchAlefHamza { get; set; }

  /// <summary>
  /// The match control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchcontrol?view=word-pia"/>
  public bool MatchControl { get; set; }

  /// <summary>
  /// The match phrase.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchphrase?view=word-pia"/>
  public bool MatchPhrase { get; set; }

  /// <summary>
  /// The match prefix.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchprefix?view=word-pia"/>
  public bool MatchPrefix { get; set; }

  /// <summary>
  /// The match suffix.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchsuffix?view=word-pia"/>
  public bool MatchSuffix { get; set; }

  /// <summary>
  /// The ignore space.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.ignorespace?view=word-pia"/>
  public bool IgnoreSpace { get; set; }

  /// <summary>
  /// The ignore punct.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.ignorepunct?view=word-pia"/>
  public bool IgnorePunct { get; set; }

  /// <summary>
  /// The hanja phonetic hangul.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.hanjaphonetichangul?view=word-pia"/>
  public bool HanjaPhoneticHangul { get; set; }
}
