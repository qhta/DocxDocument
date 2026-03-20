
namespace DocumentModel.Interop.Core;

public interface IMsoChartTitle
{
  public string Caption { get; set; }
  public IMsoCharacters Characters { get; }
  public ChartFont Font { get; }
  public object HorizontalAlignment { get; set; }
  public double Left { get; set; }
  public object Orientation { get; set; }
  public bool Shadow { get; set; }
  public string Text { get; set; }
  public double Top { get; set; }
  public object VerticalAlignment { get; set; }
  public int ReadingOrder { get; set; }
  public object AutoScaleFont { get; set; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public object Delete();
  public IMsoBorder Border { get; }
  public string Name { get; }
  public object Select();
  public bool IncludeInLayout { get; set; }
  public XlChartElementPosition Position { get; set; }
  public IMsoChartFormat Format { get; }
  public double Height { get; }
  public double Width { get; }
  public string Formula { get; set; }
  public string FormulaR1C1 { get; set; }
  public string FormulaLocal { get; set; }
  public string FormulaR1C1Local { get; set; }
}
