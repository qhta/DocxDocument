
namespace DocumentModel.Interop.Core;

public interface IMsoDisplayUnitLabel: IMsoChartTitle
{
  new string Caption { get; set; }
  new IMsoCharacters Characters { get; }
  new ChartFont Font { get; }
  new object HorizontalAlignment { get; set; }
  new double Left { get; set; }
  new object Orientation { get; set; }
  new bool Shadow { get; set; }
  new string Text { get; set; }
  new double Top { get; set; }
  new object VerticalAlignment { get; set; }
  new int ReadingOrder { get; set; }
  new object AutoScaleFont { get; set; }
  new IMsoInterior Interior { get; }
  new ChartFillFormat Fill { get; }
  new object Delete();
  new IMsoBorder Border { get; }
  new string Name { get; }
  new object Parent { get; }
  new object Select();
  new bool IncludeInLayout { get; set; }
  new XlChartElementPosition Position { get; set; }
  new IMsoChartFormat Format { get; }
  new double Height { get; }
  new object Application { get; }
  new int Creator { get; }
  new double Width { get; }
  new string Formula { get; set; }
  new string FormulaR1C1 { get; set; }
  new string FormulaLocal { get; set; }
  new string FormulaR1C1Local { get; set; }
}