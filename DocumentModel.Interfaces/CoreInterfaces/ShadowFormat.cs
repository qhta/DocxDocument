
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents shadow formatting for a shape.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat?view=office-pia"/>
public partial interface ShadowFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `ForeColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.forecolor?view=office-pia"/>
  public ColorFormat ForeColor { get; set; }
  /// <summary>
  /// Gets or sets the `Obscured` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.obscured?view=office-pia"/>
  public MsoTriState Obscured { get; set; }
  /// <summary>
  /// Gets or sets the `OffsetX` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.offsetx?view=office-pia"/>
  public float OffsetX { get; set; }
  /// <summary>
  /// Gets or sets the `OffsetY` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.offsety?view=office-pia"/>
  public float OffsetY { get; set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.transparency?view=office-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.type?view=office-pia"/>
  public MsoShadowType Type { get; set; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.visible?view=office-pia"/>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.style?view=office-pia"/>
  public MsoShadowStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `Blur` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.blur?view=office-pia"/>
  public float Blur { get; set; }
  /// <summary>
  /// Gets or sets the `Size` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.size?view=office-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the `RotateWithShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.rotatewithshape?view=office-pia"/>
  public MsoTriState RotateWithShape { get; set; }
}

