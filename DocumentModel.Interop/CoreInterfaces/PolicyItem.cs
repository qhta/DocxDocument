using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PolicyItem: InteropObject
{
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string Data { get; }
}