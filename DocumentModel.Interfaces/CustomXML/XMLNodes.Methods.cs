namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnodes?view=word-pia"/>
public partial interface IXMLNodes: IModelObject
{
  /// <summary>
  /// Adds a new XML node to the collection.
  /// </summary>
  /// <param name="Name">The name of the XML node to add.</param>
  /// <param name="Namespace">The namespace of the XML node.</param>
  /// <param name="Range">The range where the XML node is inserted.</param>
  /// <returns>The created <see cref="IXMLNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnodes.add?view=word-pia"/>
  public IXMLNode Add(string Name, string Namespace, object Range);
}
