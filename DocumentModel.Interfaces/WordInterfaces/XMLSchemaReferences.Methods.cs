namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences?view=word-pia"/>
public partial interface XMLSchemaReferences: InteropObject
{
  /// <summary>
  /// Verifies an individual XML element or the entire document against the attached XML schema or schemas.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.validate?view=word-pia"/>
  public void Validate();
}
