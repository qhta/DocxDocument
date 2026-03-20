
namespace DocumentModel.Interop.Core;

public partial interface IMsoSeriesLines
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoChartFormat Format { get; }
}
