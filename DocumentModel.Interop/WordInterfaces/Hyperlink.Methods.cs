namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink?view=word-pia"/>
public partial interface Hyperlink
{
  /// <summary>
  /// Deletes the hyperlink from the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlink.delete?view=word-pia"/>
  public void Delete();
}
