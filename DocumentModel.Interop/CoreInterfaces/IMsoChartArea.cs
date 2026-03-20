
namespace DocumentModel.Interop.Core;

public interface IMsoChartArea
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object Clear();
  public object ClearContents();
  public object Copy();
  public ChartFont Font { get; }
  public bool Shadow { get; set; }
  public object ClearFormats();
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
