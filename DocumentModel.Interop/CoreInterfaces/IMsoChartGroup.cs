
namespace DocumentModel.Interop.Core;

public partial interface IMsoChartGroup
{
  public int AxisGroup { get; set; }
  public int DoughnutHoleSize { get; set; }
  public IMsoDownBars DownBars { get; }
  public IMsoDropLines DropLines { get; }
  public int FirstSliceAngle { get; set; }
  public int GapWidth { get; set; }
  public bool HasDropLines { get; set; }
  public bool HasHiLoLines { get; set; }
  public bool HasRadarAxisLabels { get; set; }
  public bool HasSeriesLines { get; set; }
  public bool HasUpDownBars { get; set; }
  public IMsoHiLoLines HiLoLines { get; }
  public int Index { get; }
  public int Overlap { get; set; }
  public object RadarAxisLabels { get; }
  public IMsoSeriesLines SeriesLines { get; }
  public int SubType { get; set; }
  public int Type { get; set; }
  public IMsoUpBars UpBars { get; }
  public bool VaryByCategories { get; set; }
  public XlSizeRepresents SizeRepresents { get; set; }
  public int BubbleScale { get; set; }
  public bool ShowNegativeBubbles { get; set; }
  public XlChartSplitType SplitType { get; set; }
  public object SplitValue { get; set; }
  public int SecondPlotSize { get; set; }
  public bool Has3DShading { get; set; }
}
