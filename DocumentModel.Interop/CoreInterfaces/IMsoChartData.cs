
namespace DocumentModel.Interop.Core;

public interface IMsoChartData
{
  public object Workbook { get; }
  public void Activate();
  public bool IsLinked { get; }
  public void BreakLink();
  public void ActivateChartDataWindow();
}
