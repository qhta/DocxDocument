
namespace DocumentModel.Diagrams;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode?view=office-pia"/>
public partial interface DiagramNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `Children` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.children?view=office-pia"/>
  public DiagramNodeChildren Children { get; }
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.shape?view=office-pia"/>
  public Drw.Shape Shape { get; }
  /// <summary>
  /// Gets the `Root` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.root?view=office-pia"/>
  public DiagramNode Root { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.diagram?view=office-pia"/>
  public Diagram Diagram { get; }
  /// <summary>
  /// Gets or sets the `Layout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.layout?view=office-pia"/>
  public OrgChartLayoutType Layout { get; set; }
  /// <summary>
  /// Gets the `TextShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.textshape?view=office-pia"/>
  public Drw.Shape TextShape { get; }
}

