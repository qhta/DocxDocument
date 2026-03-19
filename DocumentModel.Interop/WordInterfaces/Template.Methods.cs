namespace DocumentModel.Interop.Word;

public partial interface Template
{
  /// <summary>
  /// Opens the template as a document.
  /// </summary>
  /// <returns>The created <see cref="Document"/> object.</returns>
  public Document OpenAsDocument();
}
