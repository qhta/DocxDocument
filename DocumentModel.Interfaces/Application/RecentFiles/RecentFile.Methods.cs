namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile?view=word-pia"/>
public partial interface IRecentFile: IModelObject
{
  /// <summary>
  /// Opens the specified recent file and returns a Document object that represents the opened document.
  /// </summary>
  /// <returns>A <see cref="IDocument"/> object representing the opened document.
  /// </returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfile.open?view=word-pia"/>
  public IDocument Open();
}
