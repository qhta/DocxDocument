
namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions: InteropObject
{
  public int FeatureReports { get; set; }
  public bool OutputToDebugger { get; set; }
  public bool OutputToFile { get; set; }
  public bool OutputToMessageBox { get; set; }
  public object UnitTestManager { get; }
  public void AddIgnoredAssertTag(string bstrTagToIgnore);
  public void RemoveIgnoredAssertTag(string bstrTagToIgnore);
}
