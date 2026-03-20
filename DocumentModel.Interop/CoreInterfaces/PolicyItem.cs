using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PolicyItem: InteropObject
{
  public string Id { get; }
  public string Name { get; }
  public string Description { get; }
  public string Data { get; }
}
