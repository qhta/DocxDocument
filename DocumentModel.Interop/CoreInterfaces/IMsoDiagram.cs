
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia"/>
public partial interface IMsoDiagram: IInteropObject
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
  public DiagramType Type { get; }
  /// <summary>
  /// Gets or sets the `AutoLayout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autolayout?view=office-pia"/>
  public TriState AutoLayout { get; set; }
  /// <summary>
  /// Gets or sets the `Reverse` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.reverse?view=office-pia"/>
  public TriState Reverse { get; set; }
  /// <summary>
  /// Gets or sets the `AutoFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.autoformat?view=office-pia"/>
  public TriState AutoFormat { get; set; }


  #region methods

/// <summary>
  /// Converts the diagram to another diagram type.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.convert?view=office-pia"/>
  public void Convert(DiagramType Type);
  /// <summary>
  /// Fits text within the diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.fittext?view=office-pia"/>
  public void FitText();

  #endregion methods
}

