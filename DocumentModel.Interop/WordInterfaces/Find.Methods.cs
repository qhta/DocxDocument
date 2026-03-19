namespace DocumentModel.Interop.Word;

public partial interface Find
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
  public bool ExecuteOld(object FindText, object MatchCase, object MatchWholeWord, object MatchWildcards, object MatchSoundsLike, object MatchAllWordForms, object Forward, object Wrap, object Format, object ReplaceWith, object Replace);
}
