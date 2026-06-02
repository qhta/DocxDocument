namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template?view=word-pia"/>
public partial interface ITemplate
{
  /// <summary>
  /// Opens the template as a document.
  /// </summary>
  /// <returns>The created <see cref="Document"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.openasdocument?view=word-pia"/>
  public Document OpenAsDocument();
}
