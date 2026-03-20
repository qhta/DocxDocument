
namespace DocumentModel.Interop.Core;

public partial interface IMsoDownBars
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public IMsoChartFormat Format { get; }
}
