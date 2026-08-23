namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a legend key in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey?view=office-pia"/>
public partial interface ILegendKey : IModelObject
{
  /// <summary>
  /// Gets or sets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.interior?view=office-pia"/>
  public Interior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.fill?view=office-pia"/>
  public IChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.invertifnegative?view=office-pia"/>
  public bool InvertIfNegative { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerbackgroundcolor?view=office-pia"/>
  public int MarkerBackgroundColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerbackgroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerBackgroundColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerforegroundcolor?view=office-pia"/>
  public int MarkerForegroundColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerforegroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerForegroundColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markersize?view=office-pia"/>
  public int MarkerSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerStyle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.markerstyle?view=office-pia"/>
  public MarkerStyle MarkerStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.picturetype?view=office-pia"/>
  public int PictureType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.pictureunit?view=office-pia"/>
  public double PictureUnit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Smooth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.smooth?view=office-pia"/>
  public bool Smooth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
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
  public bool Shadow { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.format?view=office-pia"/>
  public IChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `PictureUnit2` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegendkey.pictureunit2?view=office-pia"/>
  public double PictureUnit2 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

