
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart walls.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls?view=office-pia"/>
public partial class MsoWalls
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.interior?view=office-pia"/>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.fill?view=office-pia"/>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.picturetype?view=office-pia"/>
  public object PictureType { get; set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.pictureunit?view=office-pia"/>
  public object PictureUnit { get; set; }
  /// <summary>
  /// Gets or sets the `Thickness` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.thickness?view=office-pia"/>
  public int Thickness { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.format?view=office-pia"/>
  public MsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the chart walls.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.select?view=office-pia"/>
  public object Select() { throw new NotImplementedException(); }
  /// <summary>
  /// Clears formatting from the chart walls.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.clearformats?view=office-pia"/>
  public object ClearFormats() { throw new NotImplementedException(); }
  /// <summary>
  /// Pastes content onto the chart walls.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsowalls.paste?view=office-pia"/>
  public void Paste() { throw new NotImplementedException(); }

  #endregion methods
}


