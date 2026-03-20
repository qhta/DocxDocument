
namespace DocumentModel.Interop.Core;

public interface IMsoDownBars
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object Delete();
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public IMsoChartFormat Format { get; }
}
