using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFile: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string URL { get; }
  string CreatedBy { get; }
  object CreatedDate { get; }
  string ModifiedBy { get; }
  object ModifiedDate { get; }
  void Delete();
  object Parent { get; }
}