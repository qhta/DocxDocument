using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTManager: InteropObject
{
  public MsoDebugOptions_UTs UnitTests { get; }
  public void NotifyStartOfTestSuiteRun();
  public void NotifyEndOfTestSuiteRun();
  public bool ReportErrors { get; set; }
}
