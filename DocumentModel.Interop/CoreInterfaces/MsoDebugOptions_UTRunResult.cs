using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTRunResult: InteropObject
{
  bool Passed { get; }
  string ErrorString { get; }
}