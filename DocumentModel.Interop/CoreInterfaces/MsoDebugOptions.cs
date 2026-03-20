
namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions: InteropObject
{
  int FeatureReports { get; set; }
  bool OutputToDebugger { get; set; }
  bool OutputToFile { get; set; }
  bool OutputToMessageBox { get; set; }
  object UnitTestManager { get; }
  void AddIgnoredAssertTag(string bstrTagToIgnore);
  void RemoveIgnoredAssertTag(string bstrTagToIgnore);
}