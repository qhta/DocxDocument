
namespace DocumentModel.Interop.Core;

public partial interface WebComponentWindowExternal
{
  public int InterfaceVersion { get; }
  public string ApplicationName { get; }
  public int ApplicationVersion { get; }
  public WebComponent WebComponent { get; }
}
