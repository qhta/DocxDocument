using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UT: InteropObject
{
  string Name { get; }
  string CollectionName { get; }
  MsoDebugOptions_UTRunResult Run();
}