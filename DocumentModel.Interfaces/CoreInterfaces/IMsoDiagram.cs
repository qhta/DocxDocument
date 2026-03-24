
namespace DocumentModel.Interfaces;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia"/>
public partial interface IMsoDiagram: InteropObject
{
  /// <summary>
  /// Gets or sets the `Nodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.nodes?view=office-pia"/>
  public DiagramNodes Nodes { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.type?view=office-pia"/>
  public MsoDiagramType Type { get; }
  /// <summary>
  /// Gets or sets the `AutoLayout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autolayout?view=office-pia"/>
  public MsoTriState AutoLayout { get; set; }
  /// <summary>
  /// Gets or sets the `Reverse` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.reverse?view=office-pia"/>
  public MsoTriState Reverse { get; set; }
  /// <summary>
  /// Gets or sets the `AutoFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autoformat?view=office-pia"/>
  public MsoTriState AutoFormat { get; set; }
}

