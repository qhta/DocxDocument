
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a legend key in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey?view=office-pia"/>
public partial class MsoLegendKey
{
  /// <summary>
  /// Gets or sets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.border?view=office-pia"/>
  public MsoBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.interior?view=office-pia"/>
  public MsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.fill?view=office-pia"/>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.invertifnegative?view=office-pia"/>
  public bool InvertIfNegative { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerbackgroundcolor?view=office-pia"/>
  public int MarkerBackgroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerbackgroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerBackgroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerforegroundcolor?view=office-pia"/>
  public int MarkerForegroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerforegroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerForegroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markersize?view=office-pia"/>
  public int MarkerSize { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerStyle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerstyle?view=office-pia"/>
  public MarkerStyle MarkerStyle { get; set; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.picturetype?view=office-pia"/>
  public int PictureType { get; set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.pictureunit?view=office-pia"/>
  public double PictureUnit { get; set; }
  /// <summary>
  /// Gets or sets the `Smooth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.smooth?view=office-pia"/>
  public bool Smooth { get; set; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.left?view=office-pia"/>
  public double Left { get; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.top?view=office-pia"/>
  public double Top { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.width?view=office-pia"/>
  public double Width { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.height?view=office-pia"/>
  public double Height { get; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.shadow?view=office-pia"/>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.format?view=office-pia"/>
  public MsoChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `PictureUnit2` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.pictureunit2?view=office-pia"/>
  public double PictureUnit2 { get; set; }


  #region methods

/// <summary>
  /// Clears formatting from the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.clearformats?view=office-pia"/>
  public object ClearFormats() { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.delete?view=office-pia"/>
  public object Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Selects the legend key.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.select?view=office-pia"/>
  public object Select() { throw new NotImplementedException(); }

  #endregion methods
}


