using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceLink: InteropObject
{
  string URL { get; set; }
  string Description { get; set; }
  string Notes { get; set; }
  string CreatedBy { get; }
  object CreatedDate { get; }
  string ModifiedBy { get; }
  object ModifiedDate { get; }
  void Save();
  void Delete();
}