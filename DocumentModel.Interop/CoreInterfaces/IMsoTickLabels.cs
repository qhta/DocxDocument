
namespace DocumentModel.Interop.Core;

public partial interface IMsoTickLabels
{
  public ChartFont Font { get; }
  public string Name { get; }
  public string NumberFormat { get; set; }
  public bool NumberFormatLinked { get; set; }
  public object NumberFormatLocal { get; set; }
  public XlTickLabelOrientation Orientation { get; set; }
  public int ReadingOrder { get; set; }
  public object AutoScaleFont { get; set; }
  public int Depth { get; }
  public int Offset { get; set; }
  public int Alignment { get; set; }
  public bool MultiLevel { get; set; }
  public IMsoChartFormat Format { get; }
}
