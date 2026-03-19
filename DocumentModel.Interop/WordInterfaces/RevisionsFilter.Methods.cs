namespace DocumentModel.Interop.Word;

public partial interface RevisionsFilter
{
  /// <summary>
  /// Shows or hides all revisions in a document that contains comments and tracked changes.
  /// </summary>
  public void ToggleShowAllReviewers();
}
