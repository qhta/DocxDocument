using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UTRunResult: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  bool Passed { get; }
  string ErrorString { get; }
}