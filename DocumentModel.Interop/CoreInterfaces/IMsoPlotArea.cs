
namespace DocumentModel.Interop.Core;

public interface IMsoPlotArea
{
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object ClearFormats();
  double Height { get; set; }
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  double Left { get; set; }
  double Top { get; set; }
  double Width { get; set; }
  double InsideLeft { get; set; }
  double InsideTop { get; set; }
  double InsideWidth { get; set; }
  double InsideHeight { get; set; }
  XlChartElementPosition Position { get; set; }
  IMsoChartFormat Format { get; }
}