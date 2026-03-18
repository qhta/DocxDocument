namespace DocumentModel.Interop;

public partial interface DocumentEvents
{
  /// <summary>
  /// Occurs when a new document is created.
  /// </summary>
  public void New();

  /// <summary>
  /// Occurs when a document is opened.
  /// </summary>
  public void Open();

  /// <summary>
  /// Occurs when a document is closed.
  /// </summary>
  public void Close();
}
