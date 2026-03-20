using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFile: InteropObject
{
  string URL { get; }
  string CreatedBy { get; }
  object CreatedDate { get; }
  string ModifiedBy { get; }
  object ModifiedDate { get; }
  void Delete();
}