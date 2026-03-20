
namespace DocumentModel.Interop.Core;

public interface GridLines
{
  public string Name { get; }
  public object Select();
  public IMsoBorder Border { get; }
  public object Delete();
  public IMsoChartFormat Format { get; }
}
