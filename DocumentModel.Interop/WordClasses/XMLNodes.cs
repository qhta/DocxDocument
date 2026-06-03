namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XMLNode objects that represents the nodes in the tree view of the XML Structure task pane,
/// which indicates the elements that a user has applied to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnodes?view=word-pia"/>
public partial class XMLNodes : InteropCollection<XMLNode>
{


  #region methods

/// <summary>
  /// Adds a new XML node to the collection.
  /// </summary>
  /// <param name="name">The name of the XML node to add.</param>
  /// <param name="xmlNamespace">The namespace of the XML node.</param>
  /// <param name="range">The range where the XML node is inserted.</param>
  /// <returns>The created <see cref="XMLNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnodes.add?view=word-pia"/>
  public XMLNode Add(string name, string xmlNamespace, object range) { throw new NotImplementedException(); }

  #endregion methods
}
