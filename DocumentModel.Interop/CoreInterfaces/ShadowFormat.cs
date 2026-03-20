
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents shadow formatting for a shape.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat?view=office-pia
/// </remarks>
public partial interface ShadowFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `ForeColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.forecolor?view=office-pia
  /// </remarks>
  public ColorFormat ForeColor { get; set; }
  /// <summary>
  /// Gets or sets the `Obscured` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.obscured?view=office-pia
  /// </remarks>
  public MsoTriState Obscured { get; set; }
  /// <summary>
  /// Gets or sets the `OffsetX` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.offsetx?view=office-pia
  /// </remarks>
  public float OffsetX { get; set; }
  /// <summary>
  /// Gets or sets the `OffsetY` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.offsety?view=office-pia
  /// </remarks>
  public float OffsetY { get; set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.transparency?view=office-pia
  /// </remarks>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.type?view=office-pia
  /// </remarks>
  public MsoShadowType Type { get; set; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.visible?view=office-pia
  /// </remarks>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.style?view=office-pia
  /// </remarks>
  public MsoShadowStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `Blur` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.blur?view=office-pia
  /// </remarks>
  public float Blur { get; set; }
  /// <summary>
  /// Gets or sets the `Size` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.size?view=office-pia
  /// </remarks>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the `RotateWithShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.rotatewithshape?view=office-pia
  /// </remarks>
  public MsoTriState RotateWithShape { get; set; }
}
