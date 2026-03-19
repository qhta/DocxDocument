
namespace DocumentModel.Interop.Core;

public interface IMsoChartData
{
  object Workbook { get; }
  void Activate();
  bool IsLinked { get; }
  void BreakLink();
  void ActivateChartDataWindow();
}