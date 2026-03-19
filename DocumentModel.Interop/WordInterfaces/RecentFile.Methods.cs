namespace DocumentModel.Interop.Word;

public partial interface RecentFile
{
  /// <summary>
  /// Opens the specified recent file and returns a Document object that represents the opened document.
  /// </summary>
  /// <returns>A <see cref="Document"/> object representing the opened document.
  /// </returns>
  public Document Open();
}
