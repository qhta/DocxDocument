
namespace DocumentModel.Interop.Core;

public interface IMsoErrorBars
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object Delete();
  public object ClearFormats();
  public XlEndStyleCap EndStyle { get; set; }
  public IMsoChartFormat Format { get; }
}
