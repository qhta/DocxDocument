
namespace DocumentModel.Interop.Core;

public partial interface IMsoErrorBars
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public XlEndStyleCap EndStyle { get; set; }
  public IMsoChartFormat Format { get; }
}
