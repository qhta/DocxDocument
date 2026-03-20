
namespace DocumentModel.Interop.Core;

public partial interface IMsoDataLabel
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
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
  public bool AutoText { get; set; }
  public string NumberFormat { get; set; }
  public bool NumberFormatLinked { get; set; }
  public object NumberFormatLocal { get; set; }
  public bool ShowLegendKey { get; set; }
  public object Type { get; set; }
  public XlDataLabelPosition Position { get; set; }
  public bool ShowSeriesName { get; set; }
  public bool ShowCategoryName { get; set; }
  public bool ShowValue { get; set; }
  public bool ShowPercentage { get; set; }
  public bool ShowBubbleSize { get; set; }
  public object Separator { get; set; }
  public IMsoChartFormat Format { get; }
  public double _Height { get; }
  public double _Width { get; }
  public string Formula { get; set; }
  public string FormulaR1C1 { get; set; }
  public string FormulaLocal { get; set; }
  public string FormulaR1C1Local { get; set; }
  public bool ShowRange { get; set; }
  public double Height { get; set; }
  public double Width { get; set; }
}
