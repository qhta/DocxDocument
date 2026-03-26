using DocumentModel.Interop.Core;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents one or more series plotted in a chart with the same format.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup?view=word-pia"/>
public partial interface ChartGroup : InteropObject
{
  /// <summary>
  /// Gets or sets the axis group for the chart group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.axisgroup?view=word-pia"/>
  public AxisGroup AxisGroup { get; set; }

  /// <summary>
  /// Gets or sets the size of the hole in a doughnut chart group, as a percentage.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.doughnutholesize?view=word-pia"/>
  public int DoughnutHoleSize { get; set; }

  /// <summary>
  /// Gets the down bars for a line chart group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.downbars?view=word-pia"/>
  public DownBars DownBars { get; }

  /// <summary>
  /// Gets the drop lines for the chart group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.droplines?view=word-pia"/>
  public DropLines DropLines { get; }

  /// <summary>
  /// Gets or sets the angle of the first pie-chart or doughnut-chart slice, in degrees.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.firstsliceangle?view=word-pia"/>
  public int FirstSliceAngle { get; set; }

  /// <summary>
  /// Gets or sets the gap width between chart groups, as a percentage of bar or column width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.gapwidth?view=word-pia"/>
  public int GapWidth { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether drop lines are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasdroplines?view=word-pia"/>
  public bool HasDropLines { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether high-low lines are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hashilolines?view=word-pia"/>
  public bool HasHiLoLines { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether radar axis labels are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasradaraxislabels?view=word-pia"/>
  public bool HasRadarAxisLabels { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether series lines are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasserieslines?view=word-pia"/>
  public bool HasSeriesLines { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether up bars and down bars are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasupdownbars?view=word-pia"/>
  public bool HasUpDownBars { get; set; }

  /// <summary>
  /// Gets the high-low lines for the chart group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hilolines?view=word-pia"/>
  public HiLoLines HiLoLines { get; }

  /// <summary>
  /// Gets the index number of the chart group in the `ChartGroups` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets how much bars or columns overlap, as a percentage.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.overlap?view=word-pia"/>
  public int Overlap { get; set; }

  /// <summary>
  /// Gets the radar axis labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.radaraxislabels?view=word-pia"/>
  public TickLabels RadarAxisLabels { get; }

  /// <summary>
  /// Gets the series lines for stacked bar and stacked column charts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.serieslines?view=word-pia"/>
  public SeriesLines SeriesLines { get; }

  /// <summary>
  /// Gets or sets the chart subtype for the chart group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.subtype?view=word-pia"/>
  public int SubType { get; set; }

  /// <summary>
  /// Gets or sets the chart type for the chart group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.type?view=word-pia"/>
  public int Type { get; set; }

  /// <summary>
  /// Gets the up bars for a line chart group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.upbars?view=word-pia"/>
  public UpBars UpBars { get; }

  /// <summary>
  /// Gets or sets a value indicating whether each data marker has a different color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.varybycategories?view=word-pia"/>
  public bool VaryByCategories { get; set; }

  /// <summary>
  /// Gets or sets what the bubble size represents in a bubble chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.sizerepresents?view=word-pia"/>
  public SizeRepresents SizeRepresents { get; set; }

  /// <summary>
  /// Gets or sets the scale factor for bubbles in a bubble chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.bubblescale?view=word-pia"/>
  public int BubbleScale { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether negative bubbles are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.shownegativebubbles?view=word-pia"/>
  public bool ShowNegativeBubbles { get; set; }

  /// <summary>
  /// Gets or sets the criterion used to split a pie-of-pie or bar-of-pie chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.splittype?view=word-pia"/>
  public ChartSplitType SplitType { get; set; }

  /// <summary>
  /// Gets or sets the split threshold value for a pie-of-pie or bar-of-pie chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.splitvalue?view=word-pia"/>
  public object SplitValue { get; set; }

  /// <summary>
  /// Gets or sets the size of the secondary plot in a pie-of-pie or bar-of-pie chart, as a percentage.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.secondplotsize?view=word-pia"/>
  public int SecondPlotSize { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether 3-D shading is used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.has3dshading?view=word-pia"/>
  public bool Has3DShading { get; set; }
}
