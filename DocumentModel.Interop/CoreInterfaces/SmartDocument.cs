
namespace DocumentModel.Interop.Core;

public interface SmartDocument: InteropObject
{
  string SolutionID { get; set; }
  string SolutionURL { get; set; }
  void PickSolution(bool ConsiderAllSchemas);
  void RefreshPane();
}