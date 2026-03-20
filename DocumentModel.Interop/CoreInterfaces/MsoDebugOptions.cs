
namespace DocumentModel.Interop.Core;

public partial interface MsoDebugOptions: InteropObject
{
  public int FeatureReports { get; set; }
  public bool OutputToDebugger { get; set; }
  public bool OutputToFile { get; set; }
  public bool OutputToMessageBox { get; set; }
  public object UnitTestManager { get; }
}
