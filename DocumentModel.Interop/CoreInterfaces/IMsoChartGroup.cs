
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoChartGroup` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoChartGroup
{
  /// <summary>
  /// Gets or sets the `AxisGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.axisgroup?view=office-pia
  /// </remarks>
  public int AxisGroup { get; set; }
  /// <summary>
  /// Gets or sets the `DoughnutHoleSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.doughnutholesize?view=office-pia
  /// </remarks>
  public int DoughnutHoleSize { get; set; }
  /// <summary>
  /// Gets the `DownBars` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.downbars?view=office-pia
  /// </remarks>
  public IMsoDownBars DownBars { get; }
  /// <summary>
  /// Gets the `DropLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.droplines?view=office-pia
  /// </remarks>
  public IMsoDropLines DropLines { get; }
  /// <summary>
  /// Gets or sets the `FirstSliceAngle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.firstsliceangle?view=office-pia
  /// </remarks>
  public int FirstSliceAngle { get; set; }
  /// <summary>
  /// Gets or sets the `GapWidth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.gapwidth?view=office-pia
  /// </remarks>
  public int GapWidth { get; set; }
  /// <summary>
  /// Gets or sets the `HasDropLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasdroplines?view=office-pia
  /// </remarks>
  public bool HasDropLines { get; set; }
  /// <summary>
  /// Gets or sets the `HasHiLoLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hashilolines?view=office-pia
  /// </remarks>
  public bool HasHiLoLines { get; set; }
  /// <summary>
  /// Gets or sets the `HasRadarAxisLabels` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasradaraxislabels?view=office-pia
  /// </remarks>
  public bool HasRadarAxisLabels { get; set; }
  /// <summary>
  /// Gets or sets the `HasSeriesLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasserieslines?view=office-pia
  /// </remarks>
  public bool HasSeriesLines { get; set; }
  /// <summary>
  /// Gets or sets the `HasUpDownBars` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hasupdownbars?view=office-pia
  /// </remarks>
  public bool HasUpDownBars { get; set; }
  /// <summary>
  /// Gets the `HiLoLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.hilolines?view=office-pia
  /// </remarks>
  public IMsoHiLoLines HiLoLines { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.index?view=office-pia
  /// </remarks>
  public int Index { get; }
  /// <summary>
  /// Gets or sets the `Overlap` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.overlap?view=office-pia
  /// </remarks>
  public int Overlap { get; set; }
  /// <summary>
  /// Gets the `RadarAxisLabels` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.radaraxislabels?view=office-pia
  /// </remarks>
  public object RadarAxisLabels { get; }
  /// <summary>
  /// Gets the `SeriesLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.serieslines?view=office-pia
  /// </remarks>
  public IMsoSeriesLines SeriesLines { get; }
  /// <summary>
  /// Gets or sets the `SubType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.subtype?view=office-pia
  /// </remarks>
  public int SubType { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.type?view=office-pia
  /// </remarks>
  public int Type { get; set; }
  /// <summary>
  /// Gets the `UpBars` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.upbars?view=office-pia
  /// </remarks>
  public IMsoUpBars UpBars { get; }
  /// <summary>
  /// Gets or sets the `VaryByCategories` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.varybycategories?view=office-pia
  /// </remarks>
  public bool VaryByCategories { get; set; }
  /// <summary>
  /// Gets or sets the `SizeRepresents` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.sizerepresents?view=office-pia
  /// </remarks>
  public XlSizeRepresents SizeRepresents { get; set; }
  /// <summary>
  /// Gets or sets the `BubbleScale` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.bubblescale?view=office-pia
  /// </remarks>
  public int BubbleScale { get; set; }
  /// <summary>
  /// Gets or sets the `ShowNegativeBubbles` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.shownegativebubbles?view=office-pia
  /// </remarks>
  public bool ShowNegativeBubbles { get; set; }
  /// <summary>
  /// Gets or sets the `SplitType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.splittype?view=office-pia
  /// </remarks>
  public XlChartSplitType SplitType { get; set; }
  /// <summary>
  /// Gets or sets the `SplitValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.splitvalue?view=office-pia
  /// </remarks>
  public object SplitValue { get; set; }
  /// <summary>
  /// Gets or sets the `SecondPlotSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.secondplotsize?view=office-pia
  /// </remarks>
  public int SecondPlotSize { get; set; }
  /// <summary>
  /// Gets or sets the `Has3DShading` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.has3dshading?view=office-pia
  /// </remarks>
  public bool Has3DShading { get; set; }
}
