
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoWalls` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoWalls
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.interior?view=office-pia
  /// </remarks>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.fill?view=office-pia
  /// </remarks>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.picturetype?view=office-pia
  /// </remarks>
  public object PictureType { get; set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.pictureunit?view=office-pia
  /// </remarks>
  public object PictureUnit { get; set; }
  /// <summary>
  /// Gets or sets the `Thickness` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.thickness?view=office-pia
  /// </remarks>
  public int Thickness { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
}
