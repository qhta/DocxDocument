using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceMember: InteropObject
{
  public string DomainName { get; }
  public string Name { get; }
  public string Email { get; }
  public void Delete();
  public string Id { get; }
}
