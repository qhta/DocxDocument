
namespace DocumentModel.Interop.Core;

public interface SmartDocument: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string SolutionID { get; set; }
  string SolutionURL { get; set; }
  void PickSolution(bool ConsiderAllSchemas);
  void RefreshPane();
}