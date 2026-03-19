using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UT: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  string CollectionName { get; }
  MsoDebugOptions_UTRunResult Run();
}