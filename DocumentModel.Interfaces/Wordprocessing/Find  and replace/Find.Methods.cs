namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find?view=word-pia"/>
public partial interface IFind : IModelObject
{
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
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.find.executeold?view=word-pia"/>
  public bool ExecuteOld(object FindText, object MatchCase, object MatchWholeWord, object MatchWildcards, object MatchSoundsLike, object MatchAllWordForms, object Forward, object Wrap, object Format, object ReplaceWith, object Replace);
}
