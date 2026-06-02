namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the criteria for a find operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find?view=word-pia"/>
public partial interface IFind : IInteropObject
{
  /// <summary>
  /// Determines if the find operation searches forward through the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.forward?view=word-pia"/>
  public bool Forward { get; set; }

  /// <summary>
  /// Returns or sets a <see cref="Font"/> object that represents the character formatting of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// Determines if the search for the specified object has produced a match.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.found?view=word-pia"/>
  public bool Found { get; }

  /// <summary>
  /// Determines if all forms of the text to find are found by the find operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchallwordforms?view=word-pia"/>
  public bool MatchAllWordForms { get; set; }

  /// <summary>
  /// Determines if the find operation is case-sensitive.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchcase?view=word-pia"/>
  public bool MatchCase { get; set; }

  /// <summary>
  /// Determines if the text to find contains wildcards.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchwildcards?view=word-pia"/>
  public bool MatchWildcards { get; set; }

  /// <summary>
  /// Determines if words that sound similar to the text to find are returned by the find operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchsoundslike?view=word-pia"/>
  public bool MatchSoundsLike { get; set; }

  /// <summary>
  /// Determines if the find operation locates only entire words and not text that's part of a larger word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchwholeword?view=word-pia"/>
  public bool MatchWholeWord { get; set; }

  /// <summary>
  /// Determines if Microsoft Word uses the nonspecific search options for Japanese text during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchfuzzy?view=word-pia"/>
  public bool MatchFuzzy { get; set; }

  /// <summary>
  /// Determines if Microsoft Word distinguishes between full-width and half-width letters or characters during a search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchbyte?view=word-pia"/>
  public bool MatchByte { get; set; }

  /// <summary>
  /// Returns or sets a <see cref="ParagraphFormat"/> object that represents the paragraph settings for the specified range, selection, find or replacement operation, or style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns or sets the style for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns or sets the text to find or replace in the specified range or selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageid?view=word-pia"/>
  public LanguageID LanguageID { get; set; }

  /// <summary>
  /// Determines if highlight formatting is included in the find criteria.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.highlight?view=word-pia"/>
  public int Highlight { get; set; }

  /// <summary>
  /// Returns a <see cref="Replacement"/> object that contains the criteria for a replace operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.replacement?view=word-pia"/>
  public Replacement Replacement { get; }

  /// <summary>
  /// Returns a <see cref="Frame"/> object that represents the frame formatting for the specified style or find-and-replace operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.frame?view=word-pia"/>
  public Frame Frame { get; }

  /// <summary>
  /// Returns or sets what happens if the end or beginning of the document is reached during the search, or if the text isn't found in the specified selection or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.wrap?view=word-pia"/>
  public FindWrap Wrap { get; set; }

  /// <summary>
  /// Determine if formatting is included in the find operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.format?view=word-pia"/>
  public bool Format { get; set; }

  /// <summary>
  /// Returns or sets an East Asian language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageidfareast?view=word-pia"/>
  public LanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.languageidother?view=word-pia"/>
  public LanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// Determines if Microsoft Word automatically corrects Hangul endings when replacing Hangul text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.correcthangulendings?view=word-pia"/>
  public bool CorrectHangulEndings { get; set; }

  /// <summary>
  /// Determines if Microsoft Word finds or replaces text that the spelling and grammar checker ignores.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Determines if find operations match text with matching kashidas in an Arabic language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchkashida?view=word-pia"/>
  public bool MatchKashida { get; set; }

  /// <summary>
  /// Determines if find operations match text with matching diacritics in a right-to-left language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchdiacritics?view=word-pia"/>
  public bool MatchDiacritics { get; set; }

  /// <summary>
  /// Determines if find operations match text with matching alef hamzas in an Arabic language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchalefhamza?view=word-pia"/>
  public bool MatchAlefHamza { get; set; }

  /// <summary>
  /// Determines if find operations match text with matching bidirectional control characters in a right-to-left language document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchcontrol?view=word-pia"/>
  public bool MatchControl { get; set; }

  /// <summary>
  /// Returns or sets whether all white space and control characters between words are ignored.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchphrase?view=word-pia"/>
  public bool MatchPhrase { get; set; }

  /// <summary>
  /// Returns or sets whether words beginning with the search string are matched.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchprefix?view=word-pia"/>
  public bool MatchPrefix { get; set; }

  /// <summary>
  /// Returns or sets whether words ending with the search string are matched.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.matchsuffix?view=word-pia"/>
  public bool MatchSuffix { get; set; }

  /// <summary>
  /// Returns or sets whether a find operation should ignore extra white space in found text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.ignorespace?view=word-pia"/>
  public bool IgnoreSpace { get; set; }

  /// <summary>
  /// Returns or sets whether a find operation should ignore punctuation in found text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.ignorepunct?view=word-pia"/>
  public bool IgnorePunct { get; set; }

  /// <summary>
  /// Returns or sets whether to locate phonetic Hangul and Hanja characters in a Korean language find operation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.hanjaphonetichangul?view=word-pia"/>
  public bool HanjaPhoneticHangul { get; set; }


  #region methods

/// <summary>
  /// Determines whether ExecuteOld.
  /// </summary>
  /// <param name="FindText">Specifies the find text.</param>
  /// <param name="MatchCase">Specifies the match case.</param>
  /// <param name="MatchWholeWord">Specifies the match whole word.</param>
  /// <param name="MatchWildcards">Specifies the match wildcards.</param>
  /// <param name="MatchSoundsLike">Specifies the match sounds like.</param>
  /// <param name="MatchAllWordForms">Specifies the match all word forms.</param>
  /// <param name="Forward">Specifies the forward.</param>
  /// <param name="Wrap">Specifies the wrap.</param>
  /// <param name="Format">Specifies the format.</param>
  /// <param name="ReplaceWith">Specifies the replace with.</param>
  /// <param name="Replace">Specifies the replace.</param>
  /// <returns>true if successful; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.executeold?view=word-pia"/>
  public bool ExecuteOld(object FindText, object MatchCase, object MatchWholeWord, object MatchWildcards, object MatchSoundsLike, object MatchAllWordForms, object Forward, object Wrap, object Format, object ReplaceWith, object Replace);

  #endregion methods
}
