namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of DiagramNode objects that represents the child nodes in a diagram.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren?view=word-pia"/>
public partial class DiagramNodeChildren : InteropCollection<DiagramNode>
{
  /// <summary>
  /// Gets the first child node in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.firstchild?view=word-pia"/>
  public DiagramNode FirstChild { get; set; }

  /// <summary>
  /// Gets the last child node in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.lastchild?view=word-pia"/>
  public DiagramNode LastChild { get; set; }


  #region methods

/// <summary>
  /// Adds a node to the diagram node's children collection.
  /// </summary>
  /// <param name="Index">The position at which to insert the node.</param>
  /// <param name="NodeType">The type of node to add.</param>
  /// <returns>The newly added <see cref="DiagramNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.addnode?view=word-pia"/>
  public DiagramNode AddNode(object Index, Core.DiagramNodeType NodeType) { throw new NotImplementedException(); }

  #endregion methods
}
