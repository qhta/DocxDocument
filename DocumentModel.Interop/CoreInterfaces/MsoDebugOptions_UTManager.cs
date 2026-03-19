using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTManager: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  MsoDebugOptions_UTs UnitTests { get; }
  void NotifyStartOfTestSuiteRun();
  void NotifyEndOfTestSuiteRun();
  bool ReportErrors { get; set; }
}