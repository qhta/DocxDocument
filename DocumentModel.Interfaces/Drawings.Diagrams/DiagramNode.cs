
namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode?view=office-pia"/>
public partial interface IDiagramNode : IModelObject
{
  /// <summary>
  /// Gets or sets the `Children` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.children?view=office-pia"/>
  public IDiagramNodeChildren Children { get; }
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.shape?view=office-pia"/>
  public Drawings.IShape Shape { get; }
  /// <summary>
  /// Gets the `Root` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.root?view=office-pia"/>
  public IDiagramNode Root { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.diagram?view=office-pia"/>
  public IDiagram Diagram { get; }
  /// <summary>
  /// Gets or sets the `Layout` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.layout?view=office-pia"/>
  public OrgChartLayoutType Layout { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `TextShape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.textshape?view=office-pia"/>
  public Drawings.IShape TextShape { get; }
}

