
using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings.SmartArt;

/// <summary>
/// Represents the `SmartArtNode` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode?view=office-pia"/>
public partial interface SmartArtNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `OrgChartLayout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.orgchartlayout?view=office-pia"/>
  public OrgChartLayoutType OrgChartLayout { get; set; }
  /// <summary>
  /// Gets the `Shapes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.shapes?view=office-pia"/>
  public ShapeRange Shapes { get; }
  /// <summary>
  /// Gets the `TextFrame2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.textframe2?view=office-pia"/>
  public TextFrame2 TextFrame2 { get; }
  /// <summary>
  /// Gets the `Level` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.level?view=office-pia"/>
  public int Level { get; }
  /// <summary>
  /// Gets the `Hidden` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.hidden?view=office-pia"/>
  public TriState Hidden { get; }
  /// <summary>
  /// Gets the `Nodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.nodes?view=office-pia"/>
  public SmartArtNodes Nodes { get; }
  /// <summary>
  /// Gets the `ParentNode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.parentnode?view=office-pia"/>
  public SmartArtNode ParentNode { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnode.type?view=office-pia"/>
  public SmartArtNodeType Type { get; }
}

