
namespace DocumentModel.Interop.Core;

public interface IMsoHiLoLines
{
  public string Name { get; }
  public void Select();
  public IMsoBorder Border { get; }
  public void Delete();
  public IMsoChartFormat Format { get; }
}
