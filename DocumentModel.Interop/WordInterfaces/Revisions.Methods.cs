namespace DocumentModel.Interop.Word;

public partial interface Revisions
{
  /// <summary>
  /// Accepts all the tracked changes in a document or range. The revision marks are removed, and the changes are incorporated into the document.
  /// </summary>
  public void AcceptAll();

  /// <summary>
  /// Rejects all the tracked changes in a range. The revision marks are removed, leaving the original text intact.
  /// </summary>
  public void RejectAll();
}
