namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents one or more series plotted in a chart with the same format.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup?view=word-pia"/>
public partial interface ChartGroup : InteropObject
{
  /// <summary>
  /// The axis group.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.axisgroup?view=word-pia"/>
  public XlAxisGroup AxisGroup { get; set; }

  /// <summary>
  /// The doughnut hole size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.doughnutholesize?view=word-pia"/>
  public int DoughnutHoleSize { get; set; }

  /// <summary>
  /// The down bars.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.downbars?view=word-pia"/>
  public DownBars DownBars { get; }

  /// <summary>
  /// The drop lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.droplines?view=word-pia"/>
  public DropLines DropLines { get; }

  /// <summary>
  /// The first slice angle.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.firstsliceangle?view=word-pia"/>
  public int FirstSliceAngle { get; set; }

  /// <summary>
  /// The gap width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.gapwidth?view=word-pia"/>
  public int GapWidth { get; set; }

  /// <summary>
  /// The has drop lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasdroplines?view=word-pia"/>
  public bool HasDropLines { get; set; }

  /// <summary>
  /// The has hi lo lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hashilolines?view=word-pia"/>
  public bool HasHiLoLines { get; set; }

  /// <summary>
  /// The has radar axis labels.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasradaraxislabels?view=word-pia"/>
  public bool HasRadarAxisLabels { get; set; }

  /// <summary>
  /// The has series lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasserieslines?view=word-pia"/>
  public bool HasSeriesLines { get; set; }

  /// <summary>
  /// The has up down bars.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hasupdownbars?view=word-pia"/>
  public bool HasUpDownBars { get; set; }

  /// <summary>
  /// The hi lo lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.hilolines?view=word-pia"/>
  public HiLoLines HiLoLines { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The overlap.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.overlap?view=word-pia"/>
  public int Overlap { get; set; }

  /// <summary>
  /// The radar axis labels.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.radaraxislabels?view=word-pia"/>
  public TickLabels RadarAxisLabels { get; }

  /// <summary>
  /// The series lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.serieslines?view=word-pia"/>
  public SeriesLines SeriesLines { get; }

  /// <summary>
  /// The sub type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.subtype?view=word-pia"/>
  public int SubType { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.type?view=word-pia"/>
  public int Type { get; set; }

  /// <summary>
  /// The up bars.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.upbars?view=word-pia"/>
  public UpBars UpBars { get; }

  /// <summary>
  /// The vary by categories.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.varybycategories?view=word-pia"/>
  public bool VaryByCategories { get; set; }

  /// <summary>
  /// The size represents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.sizerepresents?view=word-pia"/>
  public XlSizeRepresents SizeRepresents { get; set; }

  /// <summary>
  /// The bubble scale.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.bubblescale?view=word-pia"/>
  public int BubbleScale { get; set; }

  /// <summary>
  /// The show negative bubbles.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.shownegativebubbles?view=word-pia"/>
  public bool ShowNegativeBubbles { get; set; }

  /// <summary>
  /// The split type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.splittype?view=word-pia"/>
  public XlChartSplitType SplitType { get; set; }

  /// <summary>
  /// The split value.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.splitvalue?view=word-pia"/>
  public object SplitValue { get; set; }

  /// <summary>
  /// The second plot size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.secondplotsize?view=word-pia"/>
  public int SecondPlotSize { get; set; }

  /// <summary>
  /// The has3 dshading.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.has3dshading?view=word-pia"/>
  public bool Has3DShading { get; set; }
}
