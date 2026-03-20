
namespace DocumentModel.Interop.Core;

public interface IMsoDataLabel
{
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object Delete();
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  string Caption { get; set; }
  IMsoCharacters Characters { get; }
  ChartFont Font { get; }
  object HorizontalAlignment { get; set; }
  double Left { get; set; }
  object Orientation { get; set; }
  bool Shadow { get; set; }
  string Text { get; set; }
  double Top { get; set; }
  object VerticalAlignment { get; set; }
  int ReadingOrder { get; set; }
  object AutoScaleFont { get; set; }
  bool AutoText { get; set; }
  string NumberFormat { get; set; }
  bool NumberFormatLinked { get; set; }
  object NumberFormatLocal { get; set; }
  bool ShowLegendKey { get; set; }
  object Type { get; set; }
  XlDataLabelPosition Position { get; set; }
  bool ShowSeriesName { get; set; }
  bool ShowCategoryName { get; set; }
  bool ShowValue { get; set; }
  bool ShowPercentage { get; set; }
  bool ShowBubbleSize { get; set; }
  object Separator { get; set; }
  IMsoChartFormat Format { get; }
  double _Height { get; }
  double _Width { get; }
  string Formula { get; set; }
  string FormulaR1C1 { get; set; }
  string FormulaLocal { get; set; }
  string FormulaR1C1Local { get; set; }
  bool ShowRange { get; set; }
  double Height { get; set; }
  double Width { get; set; }
}