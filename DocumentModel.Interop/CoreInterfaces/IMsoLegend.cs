
namespace DocumentModel.Interop.Core;

public partial interface IMsoLegend
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public ChartFont Font { get; }
  public XlLegendPosition Position { get; set; }
  public bool Shadow { get; set; }
  public double Height { get; set; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public double Left { get; set; }
  public double Top { get; set; }
  public double Width { get; set; }
  public object AutoScaleFont { get; set; }
  public bool IncludeInLayout { get; set; }
  public IMsoChartFormat Format { get; }
}
