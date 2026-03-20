using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceTask: InteropObject
{
  string Title { get; set; }
  string AssignedTo { get; set; }
  MsoSharedWorkspaceTaskStatus Status { get; set; }
  MsoSharedWorkspaceTaskPriority Priority { get; set; }
  string Description { get; set; }
  object DueDate { get; set; }
  string CreatedBy { get; }
  object CreatedDate { get; }
  string ModifiedBy { get; }
  object ModifiedDate { get; }
  void Save();
  void Delete();
}