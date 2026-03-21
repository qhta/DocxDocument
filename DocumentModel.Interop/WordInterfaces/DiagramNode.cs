namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single diagram node within a diagram.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode?view=word-pia"/>
public partial interface DiagramNode : InteropObject
{
  /// <summary>
  /// The children.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.children?view=word-pia"/>
  public DiagramNodeChildren Children { get; }

  /// <summary>
  /// The shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.shape?view=word-pia"/>
  public Shape Shape { get; }

  /// <summary>
  /// The root.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.root?view=word-pia"/>
  public DiagramNode Root { get; }

  /// <summary>
  /// The diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.diagram?view=word-pia"/>
  public Diagram Diagram { get; }

  /// <summary>
  /// The layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.layout?view=word-pia"/>
  public Core.MsoOrgChartLayoutType Layout { get; set; }

  /// <summary>
  /// The text shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.diagramnode.textshape?view=word-pia"/>
  public Shape TextShape { get; }
}
