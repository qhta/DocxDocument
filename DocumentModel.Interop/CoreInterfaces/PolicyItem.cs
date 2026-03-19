using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface PolicyItem: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string Data { get; }
  object Parent { get; }
}