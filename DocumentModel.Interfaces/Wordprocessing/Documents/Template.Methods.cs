namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template?view=word-pia"/>
public partial interface ITemplate: IModelObject
{
  /// <summary>
  /// Opens the template as a document.
  /// </summary>
  /// <returns>The created <see cref="IDocument"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.template.openasdocument?view=word-pia"/>
  public IDocument OpenAsDocument();
}
