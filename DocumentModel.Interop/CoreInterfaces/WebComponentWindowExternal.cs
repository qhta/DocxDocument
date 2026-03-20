
namespace DocumentModel.Interop.Core;

public interface WebComponentWindowExternal
{
  int InterfaceVersion { get; }
  string ApplicationName { get; }
  int ApplicationVersion { get; }
  void CloseWindow();
  WebComponent WebComponent { get; }
}