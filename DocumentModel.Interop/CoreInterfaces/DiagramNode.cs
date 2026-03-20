
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode?view=office-pia
/// </remarks>
public partial interface DiagramNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `Children` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.children?view=office-pia
  /// </remarks>
  public DiagramNodeChildren Children { get; }
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.shape?view=office-pia
  /// </remarks>
  public Shape Shape { get; }
  /// <summary>
  /// Gets the `Root` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.root?view=office-pia
  /// </remarks>
  public DiagramNode Root { get; }
  /// <summary>
  /// Gets the `Diagram` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.diagram?view=office-pia
  /// </remarks>
  public IMsoDiagram Diagram { get; }
  /// <summary>
  /// Gets or sets the `Layout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.layout?view=office-pia
  /// </remarks>
  public MsoOrgChartLayoutType Layout { get; set; }
  /// <summary>
  /// Gets the `TextShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnode.textshape?view=office-pia
  /// </remarks>
  public Shape TextShape { get; }
}
