
namespace DocumentModel.Interop.Core;

public interface ChartPoint
{
  object Parent { get; }

  object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);

  IMsoBorder Border { get; }
  object ClearFormats();
  object Copy();
  IMsoDataLabel DataLabel { get; }
  object Delete();
  int Explosion { get; set; }
  bool HasDataLabel { get; set; }
  IMsoInterior Interior { get; }
  bool InvertIfNegative { get; set; }
  int MarkerBackgroundColor { get; set; }
  XlColorIndex MarkerBackgroundColorIndex { get; set; }
  int MarkerForegroundColor { get; set; }
  XlColorIndex MarkerForegroundColorIndex { get; set; }
  int MarkerSize { get; set; }
  XlMarkerStyle MarkerStyle { get; set; }
  object Paste();
  XlChartPictureType PictureType { get; set; }
  double PictureUnit { get; set; }
  object Select();
  bool ApplyPictToSides { get; set; }
  bool ApplyPictToFront { get; set; }
  bool ApplyPictToEnd { get; set; }
  bool Shadow { get; set; }
  bool SecondaryPlot { get; set; }
  ChartFillFormat Fill { get; }

  object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);

  bool Has3DEffect { get; set; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
  double PictureUnit2 { get; set; }
  string Name { get; }
  double Height { get; }
  double Width { get; }
  double Left { get; }
  double Top { get; }
  double PieSliceLocation(XlPieSliceLocation loc, XlPieSliceIndex Index);
}