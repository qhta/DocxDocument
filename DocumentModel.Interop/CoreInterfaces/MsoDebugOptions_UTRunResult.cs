using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface MsoDebugOptions_UTRunResult: InteropObject
{
  public bool Passed { get; }
  public string ErrorString { get; }
}
