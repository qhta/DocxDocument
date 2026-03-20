
namespace DocumentModel.Interop.Core;

public interface SmartDocument: InteropObject
{
  public string SolutionID { get; set; }
  public string SolutionURL { get; set; }
  public void PickSolution(bool ConsiderAllSchemas);
  public void RefreshPane();
}
