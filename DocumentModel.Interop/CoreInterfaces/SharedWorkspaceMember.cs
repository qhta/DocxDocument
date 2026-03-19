using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceMember: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string DomainName { get; }
  string Name { get; }
  string Email { get; }
  void Delete();
  string Id { get; }
  object Parent { get; }
}