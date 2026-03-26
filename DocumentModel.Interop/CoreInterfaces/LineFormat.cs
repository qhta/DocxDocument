
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents line formatting for a shape.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat?view=office-pia"/>
public partial interface LineFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `BackColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.backcolor?view=office-pia"/>
  public ColorFormat BackColor { get; set; }
  /// <summary>
  /// Gets or sets the `BeginArrowheadLength` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.beginarrowheadlength?view=office-pia"/>
  public ArrowheadLength BeginArrowheadLength { get; set; }
  /// <summary>
  /// Gets or sets the `BeginArrowheadStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.beginarrowheadstyle?view=office-pia"/>
  public ArrowheadStyle BeginArrowheadStyle { get; set; }
  /// <summary>
  /// Gets or sets the `BeginArrowheadWidth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.beginarrowheadwidth?view=office-pia"/>
  public ArrowheadWidth BeginArrowheadWidth { get; set; }
  /// <summary>
  /// Gets or sets the `DashStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.dashstyle?view=office-pia"/>
  public LineDashStyle DashStyle { get; set; }
  /// <summary>
  /// Gets or sets the `EndArrowheadLength` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.endarrowheadlength?view=office-pia"/>
  public ArrowheadLength EndArrowheadLength { get; set; }
  /// <summary>
  /// Gets or sets the `EndArrowheadStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.endarrowheadstyle?view=office-pia"/>
  public ArrowheadStyle EndArrowheadStyle { get; set; }
  /// <summary>
  /// Gets or sets the `EndArrowheadWidth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.endarrowheadwidth?view=office-pia"/>
  public ArrowheadWidth EndArrowheadWidth { get; set; }
  /// <summary>
  /// Gets or sets the `ForeColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.forecolor?view=office-pia"/>
  public ColorFormat ForeColor { get; set; }
  /// <summary>
  /// Gets or sets the `Pattern` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.pattern?view=office-pia"/>
  public PatternType Pattern { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.style?view=office-pia"/>
  public LineStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.transparency?view=office-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.visible?view=office-pia"/>
  public TriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Weight` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.weight?view=office-pia"/>
  public float Weight { get; set; }
  /// <summary>
  /// Gets or sets the `InsetPen` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.insetpen?view=office-pia"/>
  public TriState InsetPen { get; set; }
}

