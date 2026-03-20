using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceMember: InteropObject
{
  string DomainName { get; }
  string Name { get; }
  string Email { get; }
  void Delete();
  string Id { get; }
}