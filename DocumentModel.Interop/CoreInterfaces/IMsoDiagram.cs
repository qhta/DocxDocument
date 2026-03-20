
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia
/// </remarks>
public partial interface IMsoDiagram: InteropObject
{
  /// <summary>
  /// Gets or sets the `Nodes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.nodes?view=office-pia
  /// </remarks>
  public DiagramNodes Nodes { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.type?view=office-pia
  /// </remarks>
  public MsoDiagramType Type { get; }
  /// <summary>
  /// Gets or sets the `AutoLayout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autolayout?view=office-pia
  /// </remarks>
  public MsoTriState AutoLayout { get; set; }
  /// <summary>
  /// Gets or sets the `Reverse` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.reverse?view=office-pia
  /// </remarks>
  public MsoTriState Reverse { get; set; }
  /// <summary>
  /// Gets or sets the `AutoFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autoformat?view=office-pia
  /// </remarks>
  public MsoTriState AutoFormat { get; set; }
}
