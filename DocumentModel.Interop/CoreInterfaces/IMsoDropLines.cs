
namespace DocumentModel.Interop.Core;

public partial interface IMsoDropLines
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoChartFormat Format { get; }
}
