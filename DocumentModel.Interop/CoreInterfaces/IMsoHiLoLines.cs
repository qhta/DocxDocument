
namespace DocumentModel.Interop.Core;

public partial interface IMsoHiLoLines
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoChartFormat Format { get; }
}
