namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile?view=word-pia"/>
public partial interface RecentFile: InteropObject
{
  /// <summary>
  /// Opens the specified recent file and returns a Document object that represents the opened document.
  /// </summary>
  /// <returns>A <see cref="Document"/> object representing the opened document.
  /// </returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.open?view=word-pia"/>
  public Document Open();
}
