
namespace DocumentModel.Interop.Core;

public interface WebComponentWindowExternal
{
  public int InterfaceVersion { get; }
  public string ApplicationName { get; }
  public int ApplicationVersion { get; }
  public void CloseWindow();
  public WebComponent WebComponent { get; }
}
