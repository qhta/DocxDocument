
namespace DocumentModel.Interop.Core;

public interface IMsoChartGroup
{
  int AxisGroup { get; set; }
  int DoughnutHoleSize { get; set; }
  IMsoDownBars DownBars { get; }
  IMsoDropLines DropLines { get; }
  int FirstSliceAngle { get; set; }
  int GapWidth { get; set; }
  bool HasDropLines { get; set; }
  bool HasHiLoLines { get; set; }
  bool HasRadarAxisLabels { get; set; }
  bool HasSeriesLines { get; set; }
  bool HasUpDownBars { get; set; }
  IMsoHiLoLines HiLoLines { get; }
  int Index { get; }
  int Overlap { get; set; }
  object RadarAxisLabels { get; }
  object SeriesCollection(object Index);
  IMsoSeriesLines SeriesLines { get; }
  int SubType { get; set; }
  int Type { get; set; }
  IMsoUpBars UpBars { get; }
  bool VaryByCategories { get; set; }
  XlSizeRepresents SizeRepresents { get; set; }
  int BubbleScale { get; set; }
  bool ShowNegativeBubbles { get; set; }
  XlChartSplitType SplitType { get; set; }
  object SplitValue { get; set; }
  int SecondPlotSize { get; set; }
  bool Has3DShading { get; set; }
  object Application { get; }
  int Creator { get; }
  object Parent { get; }
  object CategoryCollection(object Index);
  object FullCategoryCollection(object Index);
}