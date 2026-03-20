
namespace DocumentModel.Interop.Core;

public partial interface GridLines
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoChartFormat Format { get; }
}
