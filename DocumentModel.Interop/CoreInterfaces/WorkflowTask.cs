using System;

namespace DocumentModel.Interop.Core;

public interface WorkflowTask: InteropObject
{
  public string Id { get; }
  public string ListID { get; }
  public string WorkflowID { get; }
  public string Name { get; }
  public string Description { get; }
  public string AssignedTo { get; }
  public string CreatedBy { get; }
  public DateTime DueDate { get; }
  public DateTime CreatedDate { get; }
  public int Show();
}
