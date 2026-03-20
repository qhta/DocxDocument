
namespace DocumentModel.Interop.Core;

public interface IMsoLegend
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object Delete();
  public ChartFont Font { get; }
  public object LegendEntries(object Index);
  public XlLegendPosition Position { get; set; }
  public bool Shadow { get; set; }
  public object Clear();
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
