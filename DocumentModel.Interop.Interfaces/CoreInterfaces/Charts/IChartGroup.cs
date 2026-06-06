
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup?view=office-pia"/>
public interface IChartGroup
{
  /// <summary>
  /// Gets or sets the `AxisGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.axisgroup?view=office-pia"/>
  public int AxisGroup { get; set; }
  /// <summary>
  /// Gets or sets the `DoughnutHoleSize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.doughnutholesize?view=office-pia"/>
  public int DoughnutHoleSize { get; set; }
  /// <summary>
  /// Gets the `DownBars` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.downbars?view=office-pia"/>
  public IDownBars DownBars { get; }
  /// <summary>
  /// Gets the `DropLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.droplines?view=office-pia"/>
  public IDropLines DropLines { get; }
  /// <summary>
  /// Gets or sets the `FirstSliceAngle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.firstsliceangle?view=office-pia"/>
  public int FirstSliceAngle { get; set; }
  /// <summary>
  /// Gets or sets the `GapWidth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.gapwidth?view=office-pia"/>
  public int GapWidth { get; set; }
  /// <summary>
  /// Gets or sets the `HasDropLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasdroplines?view=office-pia"/>
  public bool HasDropLines { get; set; }
  /// <summary>
  /// Gets or sets the `HasHiLoLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hashilolines?view=office-pia"/>
  public bool HasHiLoLines { get; set; }
  /// <summary>
  /// Gets or sets the `HasRadarAxisLabels` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasradaraxislabels?view=office-pia"/>
  public bool HasRadarAxisLabels { get; set; }
  /// <summary>
  /// Gets or sets the `HasSeriesLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasserieslines?view=office-pia"/>
  public bool HasSeriesLines { get; set; }
  /// <summary>
  /// Gets or sets the `HasUpDownBars` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasupdownbars?view=office-pia"/>
  public bool HasUpDownBars { get; set; }
  /// <summary>
  /// Gets the `HiLoLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hilolines?view=office-pia"/>
  public IHiLoLines HiLoLines { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets or sets the `Overlap` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.overlap?view=office-pia"/>
  public int Overlap { get; set; }
  /// <summary>
  /// Gets the `RadarAxisLabels` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.radaraxislabels?view=office-pia"/>
  public object RadarAxisLabels { get; }
  /// <summary>
  /// Gets the `SeriesLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.serieslines?view=office-pia"/>
  public ISeriesLines SeriesLines { get; }
  /// <summary>
  /// Gets or sets the `SubType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.subtype?view=office-pia"/>
  public int SubType { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.type?view=office-pia"/>
  public int Type { get; set; }
  /// <summary>
  /// Gets the `UpBars` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.upbars?view=office-pia"/>
  public IUpBars UpBars { get; }
  /// <summary>
  /// Gets or sets the `VaryByCategories` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.varybycategories?view=office-pia"/>
  public bool VaryByCategories { get; set; }
  /// <summary>
  /// Gets or sets the `SizeRepresents` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.sizerepresents?view=office-pia"/>
  public SizeRepresents SizeRepresents { get; set; }
  /// <summary>
  /// Gets or sets the `BubbleScale` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.bubblescale?view=office-pia"/>
  public int BubbleScale { get; set; }
  /// <summary>
  /// Gets or sets the `ShowNegativeBubbles` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.shownegativebubbles?view=office-pia"/>
  public bool ShowNegativeBubbles { get; set; }
  /// <summary>
  /// Gets or sets the `SplitType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.splittype?view=office-pia"/>
  public ChartSplitType SplitType { get; set; }
  /// <summary>
  /// Gets or sets the `SplitValue` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.splitvalue?view=office-pia"/>
  public object SplitValue { get; set; }
  /// <summary>
  /// Gets or sets the `SecondPlotSize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.secondplotsize?view=office-pia"/>
  public int SecondPlotSize { get; set; }
  /// <summary>
  /// Gets or sets the `Has3DShading` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.has3dshading?view=office-pia"/>
  public bool Has3DShading { get; set; }


  #region methods

/// <summary>
  /// Returns a series collection from the chart group.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.seriescollection?view=office-pia"/>
  public object SeriesCollection(object index);
  /// <summary>
  /// Returns a category collection from the chart group.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.categorycollection?view=office-pia"/>
  public object CategoryCollection(object index);
  /// <summary>
  /// Returns a full category collection from the chart group.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.fullcategorycollection?view=office-pia"/>
  public object FullCategoryCollection(object index);

  #endregion methods
}


