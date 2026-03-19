namespace DocumentModel.Interop.Word;

public partial interface Revision
{
  /// <summary>
  /// Accepts the specified tracked change. The revision marks are removed, and the change is incorporated into the document.
  /// </summary>
  public void Accept();
}
