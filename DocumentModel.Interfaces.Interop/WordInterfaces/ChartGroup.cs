namespace DocumentModel.Interop;

/// <summary>
/// Represents one or more series plotted in a chart with the same format.
/// </summary>
public partial interface ChartGroup : InteropObject
{
  /// <summary>
  /// The axis group.
  /// </summary>
  public XlAxisGroup AxisGroup { get; set; }

  /// <summary>
  /// The doughnut hole size.
  /// </summary>
  public int DoughnutHoleSize { get; set; }

  /// <summary>
  /// The down bars.
  /// </summary>
  public DownBars DownBars { get; }

  /// <summary>
  /// The drop lines.
  /// </summary>
  public DropLines DropLines { get; }

  /// <summary>
  /// The first slice angle.
  /// </summary>
  public int FirstSliceAngle { get; set; }

  /// <summary>
  /// The gap width.
  /// </summary>
  public int GapWidth { get; set; }

  /// <summary>
  /// The has drop lines.
  /// </summary>
  public bool HasDropLines { get; set; }

  /// <summary>
  /// The has hi lo lines.
  /// </summary>
  public bool HasHiLoLines { get; set; }

  /// <summary>
  /// The has radar axis labels.
  /// </summary>
  public bool HasRadarAxisLabels { get; set; }

  /// <summary>
  /// The has series lines.
  /// </summary>
  public bool HasSeriesLines { get; set; }

  /// <summary>
  /// The has up down bars.
  /// </summary>
  public bool HasUpDownBars { get; set; }

  /// <summary>
  /// The hi lo lines.
  /// </summary>
  public HiLoLines HiLoLines { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The overlap.
  /// </summary>
  public int Overlap { get; set; }

  /// <summary>
  /// The radar axis labels.
  /// </summary>
  public TickLabels RadarAxisLabels { get; }

  /// <summary>
  /// The series lines.
  /// </summary>
  public SeriesLines SeriesLines { get; }

  /// <summary>
  /// The sub type.
  /// </summary>
  public int SubType { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public int Type { get; set; }

  /// <summary>
  /// The up bars.
  /// </summary>
  public UpBars UpBars { get; }

  /// <summary>
  /// The vary by categories.
  /// </summary>
  public bool VaryByCategories { get; set; }

  /// <summary>
  /// The size represents.
  /// </summary>
  public XlSizeRepresents SizeRepresents { get; set; }

  /// <summary>
  /// The bubble scale.
  /// </summary>
  public int BubbleScale { get; set; }

  /// <summary>
  /// The show negative bubbles.
  /// </summary>
  public bool ShowNegativeBubbles { get; set; }

  /// <summary>
  /// The split type.
  /// </summary>
  public XlChartSplitType SplitType { get; set; }

  /// <summary>
  /// The split value.
  /// </summary>
  public object SplitValue { get; set; }

  /// <summary>
  /// The second plot size.
  /// </summary>
  public int SecondPlotSize { get; set; }

  /// <summary>
  /// The has3 dshading.
  /// </summary>
  public bool Has3DShading { get; set; }
}
