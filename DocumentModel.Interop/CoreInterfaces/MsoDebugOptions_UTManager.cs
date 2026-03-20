using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTManager: InteropObject
{
  MsoDebugOptions_UTs UnitTests { get; }
  void NotifyStartOfTestSuiteRun();
  void NotifyEndOfTestSuiteRun();
  bool ReportErrors { get; set; }
}