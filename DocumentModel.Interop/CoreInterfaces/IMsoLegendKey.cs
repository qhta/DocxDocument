
namespace DocumentModel.Interop.Core;

public interface IMsoLegendKey
{
  IMsoBorder Border { get; }
  object ClearFormats();
  object Delete();
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  bool InvertIfNegative { get; set; }
  int MarkerBackgroundColor { get; set; }
  XlColorIndex MarkerBackgroundColorIndex { get; set; }
  int MarkerForegroundColor { get; set; }
  XlColorIndex MarkerForegroundColorIndex { get; set; }
  int MarkerSize { get; set; }
  XlMarkerStyle MarkerStyle { get; set; }
  int PictureType { get; set; }
  double PictureUnit { get; set; }
  object Select();
  bool Smooth { get; set; }
  double Left { get; }
  double Top { get; }
  double Width { get; }
  double Height { get; }
  bool Shadow { get; set; }
  IMsoChartFormat Format { get; }
  double PictureUnit2 { get; set; }
}