using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceTask: InteropObject
{
  public string Title { get; set; }
  public string AssignedTo { get; set; }
  public MsoSharedWorkspaceTaskStatus Status { get; set; }
  public MsoSharedWorkspaceTaskPriority Priority { get; set; }
  public string Description { get; set; }
  public object DueDate { get; set; }
  public string CreatedBy { get; }
  public object CreatedDate { get; }
  public string ModifiedBy { get; }
  public object ModifiedDate { get; }
  public void Save();
  public void Delete();
}
