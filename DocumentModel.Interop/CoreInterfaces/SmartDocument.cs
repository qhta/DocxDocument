
namespace DocumentModel.Interop.Core;

public partial interface SmartDocument: InteropObject
{
  public string SolutionID { get; set; }
  public string SolutionURL { get; set; }
}
