using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface MsoDebugOptions_UTManager
{
  public void NotifyStartOfTestSuiteRun();
  public void NotifyEndOfTestSuiteRun();
}
