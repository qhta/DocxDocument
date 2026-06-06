namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents an individual schema that is attached to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference?view=word-pia"/>
public interface IXMLSchemaReference : IInteropObject
{
  /// <summary>
  /// Returns a String that represents the Uniform Resource Identifier (URI) of the schema namespace for the
  /// specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }	
  /// <summary>
  /// Returns a String indicating the location of the specified XML schema.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.location?view=word-pia"/>
  public string Location { get; }	

  #region methods	
/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.delete?view=word-pia"/>
  public void Delete();	
  #endregion methods
}
