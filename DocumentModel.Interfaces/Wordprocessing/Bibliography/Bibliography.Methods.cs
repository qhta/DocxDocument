namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography?view=word-pia"/>
public partial interface IBibliography : IModelObject
{
  /// <summary>
  /// Generates a unique tag for a bibliography source.
  /// </summary>
  /// <returns>A unique source tag string.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography.generateuniquetag?view=word-pia"/>
  public string GenerateUniqueTag();
}
