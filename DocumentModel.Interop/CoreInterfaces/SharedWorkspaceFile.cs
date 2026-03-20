using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceFile: InteropObject
{
  public string URL { get; }
  public string CreatedBy { get; }
  public object CreatedDate { get; }
  public string ModifiedBy { get; }
  public object ModifiedDate { get; }
}
