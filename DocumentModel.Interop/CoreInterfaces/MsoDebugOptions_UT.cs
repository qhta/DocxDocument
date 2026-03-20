using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MsoDebugOptions_UT: InteropObject
{
  public string Name { get; }
  public string CollectionName { get; }
  public MsoDebugOptions_UTRunResult Run();
}
