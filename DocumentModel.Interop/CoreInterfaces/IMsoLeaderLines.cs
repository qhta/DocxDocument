
namespace DocumentModel.Interop.Core;

public interface IMsoLeaderLines
{
  public void Select();
  public IMsoBorder Border { get; }
  public void Delete();
  public IMsoChartFormat Format { get; }
}
