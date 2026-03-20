
namespace DocumentModel.Interop.Core;

public partial interface SmartDocument
{
  public void PickSolution(bool ConsiderAllSchemas);
  public void RefreshPane();
}
