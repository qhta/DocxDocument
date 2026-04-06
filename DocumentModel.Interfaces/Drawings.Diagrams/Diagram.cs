
namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia"/>
public partial interface IDiagram: IModelObject
{
  /// <summary>
  /// Gets or sets the `Nodes` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.nodes?view=office-pia"/>
  public IDiagramNodes Nodes { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.type?view=office-pia"/>
  public DiagramType Type { get; }
  /// <summary>
  /// Gets or sets the `AutoLayout` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autolayout?view=office-pia"/>
  public TriState AutoLayout { get; set; }
  /// <summary>
  /// Gets or sets the `Reverse` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.reverse?view=office-pia"/>
  public TriState Reverse { get; set; }
  /// <summary>
  /// Gets or sets the `AutoFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autoformat?view=office-pia"/>
  public TriState AutoFormat { get; set; }
}

