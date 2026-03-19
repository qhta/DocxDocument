namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of DiagramNode objects that represents the child nodes in a diagram.
/// </summary>
public partial interface DiagramNodeChildren : InteropObject, InteropCollection<DiagramNode>
{
  /// <summary>
  /// The first child.
  /// </summary>
  public DiagramNode FirstChild { get; }

  /// <summary>
  /// The last child.
  /// </summary>
  public DiagramNode LastChild { get; }
}
