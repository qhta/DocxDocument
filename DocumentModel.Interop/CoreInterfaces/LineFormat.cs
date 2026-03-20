
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents line formatting for a shape.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat?view=office-pia
/// </remarks>
public partial interface LineFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `BackColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.backcolor?view=office-pia
  /// </remarks>
  public ColorFormat BackColor { get; set; }
  /// <summary>
  /// Gets or sets the `BeginArrowheadLength` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.beginarrowheadlength?view=office-pia
  /// </remarks>
  public MsoArrowheadLength BeginArrowheadLength { get; set; }
  /// <summary>
  /// Gets or sets the `BeginArrowheadStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.beginarrowheadstyle?view=office-pia
  /// </remarks>
  public MsoArrowheadStyle BeginArrowheadStyle { get; set; }
  /// <summary>
  /// Gets or sets the `BeginArrowheadWidth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.beginarrowheadwidth?view=office-pia
  /// </remarks>
  public MsoArrowheadWidth BeginArrowheadWidth { get; set; }
  /// <summary>
  /// Gets or sets the `DashStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.dashstyle?view=office-pia
  /// </remarks>
  public MsoLineDashStyle DashStyle { get; set; }
  /// <summary>
  /// Gets or sets the `EndArrowheadLength` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.endarrowheadlength?view=office-pia
  /// </remarks>
  public MsoArrowheadLength EndArrowheadLength { get; set; }
  /// <summary>
  /// Gets or sets the `EndArrowheadStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.endarrowheadstyle?view=office-pia
  /// </remarks>
  public MsoArrowheadStyle EndArrowheadStyle { get; set; }
  /// <summary>
  /// Gets or sets the `EndArrowheadWidth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.endarrowheadwidth?view=office-pia
  /// </remarks>
  public MsoArrowheadWidth EndArrowheadWidth { get; set; }
  /// <summary>
  /// Gets or sets the `ForeColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.forecolor?view=office-pia
  /// </remarks>
  public ColorFormat ForeColor { get; set; }
  /// <summary>
  /// Gets or sets the `Pattern` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.pattern?view=office-pia
  /// </remarks>
  public MsoPatternType Pattern { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.style?view=office-pia
  /// </remarks>
  public MsoLineStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.transparency?view=office-pia
  /// </remarks>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.visible?view=office-pia
  /// </remarks>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Weight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.weight?view=office-pia
  /// </remarks>
  public float Weight { get; set; }
  /// <summary>
  /// Gets or sets the `InsetPen` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.lineformat.insetpen?view=office-pia
  /// </remarks>
  public MsoTriState InsetPen { get; set; }
}
