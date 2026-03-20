using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspace: InteropObject
{
  public string Name { get; set; }
  public SharedWorkspaceMembers Members { get; }
  public SharedWorkspaceTasks Tasks { get; }
  public SharedWorkspaceFiles Files { get; }
  public SharedWorkspaceFolders Folders { get; }
  public SharedWorkspaceLinks Links { get; }
  public void Refresh();
  public void CreateNew(object URL, object Name);
  public void Delete();
  public string URL { get; }
  public bool Connected { get; }
  public object LastRefreshed { get; }
  public string SourceURL { get; set; }
  public void RemoveDocument();
  public void Disconnect();
}
