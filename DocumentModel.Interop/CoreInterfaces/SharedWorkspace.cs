using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspace: InteropObject
{
  string Name { get; set; }
  SharedWorkspaceMembers Members { get; }
  SharedWorkspaceTasks Tasks { get; }
  SharedWorkspaceFiles Files { get; }
  SharedWorkspaceFolders Folders { get; }
  SharedWorkspaceLinks Links { get; }
  void Refresh();
  void CreateNew(object URL, object Name);
  void Delete();
  string URL { get; }
  bool Connected { get; }
  object LastRefreshed { get; }
  string SourceURL { get; set; }
  void RemoveDocument();
  void Disconnect();
}