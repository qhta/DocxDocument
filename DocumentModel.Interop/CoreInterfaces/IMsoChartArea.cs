
namespace DocumentModel.Interop.Core;

public partial interface IMsoChartArea
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public ChartFont Font { get; }
  public bool Shadow { get; set; }
  public double Height { get; set; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public double Left { get; set; }
  public double Top { get; set; }
  public double Width { get; set; }
  public object AutoScaleFont { get; set; }
  public IMsoChartFormat Format { get; }
  public bool RoundedCorners { get; set; }
}
