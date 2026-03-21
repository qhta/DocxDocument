namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of DiagramNode objects that represents the child nodes in a diagram.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren?view=word-pia"/>
public partial interface DiagramNodeChildren : InteropObject, InteropCollection<DiagramNode>
{
  /// <summary>
  /// The first child.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.firstchild?view=word-pia"/>
  public DiagramNode FirstChild { get; }

  /// <summary>
  /// The last child.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnodechildren.lastchild?view=word-pia"/>
  public DiagramNode LastChild { get; }
}
