
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtNode` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode?view=office-pia
/// </remarks>
public partial interface SmartArtNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `OrgChartLayout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.orgchartlayout?view=office-pia
  /// </remarks>
  public MsoOrgChartLayoutType OrgChartLayout { get; set; }
  /// <summary>
  /// Gets the `Shapes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.shapes?view=office-pia
  /// </remarks>
  public ShapeRange Shapes { get; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.textframe2?view=office-pia
  /// </remarks>
  public TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `Level` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.level?view=office-pia
  /// </remarks>
  public int Level { get; }
  /// <summary>
  /// Gets the `Hidden` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.hidden?view=office-pia
  /// </remarks>
  public MsoTriState Hidden { get; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.nodes?view=office-pia
  /// </remarks>
  public SmartArtNodes Nodes { get; }
  /// <summary>
  /// Gets the `ParentNode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.parentnode?view=office-pia
  /// </remarks>
  public SmartArtNode ParentNode { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.type?view=office-pia
  /// </remarks>
  public MsoSmartArtNodeType Type { get; }
}
