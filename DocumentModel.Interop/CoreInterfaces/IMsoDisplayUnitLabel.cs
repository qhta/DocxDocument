
namespace DocumentModel.Interop.Core;

public interface IMsoDisplayUnitLabel: IMsoChartTitle
{
  public new string Caption { get; set; }
  public new IMsoCharacters Characters { get; }
  public new ChartFont Font { get; }
  public new object HorizontalAlignment { get; set; }
  public new double Left { get; set; }
  public new object Orientation { get; set; }
  public new bool Shadow { get; set; }
  public new string Text { get; set; }
  public new double Top { get; set; }
  public new object VerticalAlignment { get; set; }
  public new int ReadingOrder { get; set; }
  public new object AutoScaleFont { get; set; }
  public new IMsoInterior Interior { get; }
  public new ChartFillFormat Fill { get; }
  public new object Delete();
  public new IMsoBorder Border { get; }
  public new string Name { get; }
  public new object Select();
  public new bool IncludeInLayout { get; set; }
  public new XlChartElementPosition Position { get; set; }
  public new IMsoChartFormat Format { get; }
  public new double Height { get; }
  public new double Width { get; }
  public new string Formula { get; set; }
  public new string FormulaR1C1 { get; set; }
  public new string FormulaLocal { get; set; }
  public new string FormulaR1C1Local { get; set; }
}
