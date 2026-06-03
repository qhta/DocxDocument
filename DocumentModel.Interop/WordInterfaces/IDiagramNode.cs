namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single diagram node within a diagram.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode?view=word-pia"/>
public interface IDiagramNode : IInteropObject
{
  /// <summary>
  /// Gets the collection of child nodes for this diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.children?view=word-pia"/>
  public IDiagramNodeChildren Children { get; }

  /// <summary>
  /// Gets the shape associated with this diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.shape?view=word-pia"/>
  public IShape IShape { get; }

  /// <summary>
  /// Gets the root node of the diagram that contains this node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.root?view=word-pia"/>
  public IDiagramNode Root { get; }

  /// <summary>
  /// Gets the diagram that contains this node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.diagram?view=word-pia"/>
  public IDiagram IDiagram { get; }

  /// <summary>
  /// Gets or sets the layout type for this diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.layout?view=word-pia"/>
  public Core.OrgChartLayoutType Layout { get; set; }

  /// <summary>
  /// Gets the shape that contains text for this diagram node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.textshape?view=word-pia"/>
  public IShape TextShape { get; }


  #region methods

/// <summary>
  /// Adds a node to the diagram relative to the current node.
  /// </summary>
  /// <param name="Pos">The relative position where the new node is inserted.</param>
  /// <param name="NodeType">The type of node to add.</param>
  /// <returns>The newly added <see cref="IDiagramNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.addnode?view=word-pia"/>
  public IDiagramNode AddNode(Core.RelativeNodePosition Pos, Core.DiagramNodeType NodeType);

  #endregion methods
}
