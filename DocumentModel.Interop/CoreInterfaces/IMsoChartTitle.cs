
namespace DocumentModel.Interop.Core;

public interface IMsoChartTitle
{
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
  IMsoInterior Interior { get; }
  ChartFillFormat Fill { get; }
  object Delete();
  IMsoBorder Border { get; }
  string Name { get; }
  object Select();
  bool IncludeInLayout { get; set; }
  XlChartElementPosition Position { get; set; }
  IMsoChartFormat Format { get; }
  double Height { get; }
  double Width { get; }
  string Formula { get; set; }
  string FormulaR1C1 { get; set; }
  string FormulaLocal { get; set; }
  string FormulaR1C1Local { get; set; }
}