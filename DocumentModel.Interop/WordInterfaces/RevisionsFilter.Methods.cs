namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter?view=word-pia"/>
public partial interface IRevisionsFilter
{
  /// <summary>
  /// Shows or hides all revisions in a document that contains comments and tracked changes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisionsfilter.toggleshowallreviewers?view=word-pia"/>
  public void ToggleShowAllReviewers();
}
