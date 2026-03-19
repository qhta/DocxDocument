using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspace: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; set; }
  SharedWorkspaceMembers Members { get; }
  SharedWorkspaceTasks Tasks { get; }
  SharedWorkspaceFiles Files { get; }
  SharedWorkspaceFolders Folders { get; }
  SharedWorkspaceLinks Links { get; }
  void Refresh();
  void CreateNew(object URL, object Name);
  void Delete();
  object Parent { get; }
  string URL { get; }
  bool Connected { get; }
  object LastRefreshed { get; }
  string SourceURL { get; set; }
  void RemoveDocument();
  void Disconnect();
}