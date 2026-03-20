using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceLink: InteropObject
{
  public string URL { get; set; }
  public string Description { get; set; }
  public string Notes { get; set; }
  public string CreatedBy { get; }
  public object CreatedDate { get; }
  public string ModifiedBy { get; }
  public object ModifiedDate { get; }
  public void Save();
  public void Delete();
}
