using System;

namespace DocumentModel.Interop.Core;

public interface WorkflowTask: InteropObject
{
  string Id { get; }
  string ListID { get; }
  string WorkflowID { get; }
  string Name { get; }
  string Description { get; }
  string AssignedTo { get; }
  string CreatedBy { get; }
  DateTime DueDate { get; }
  DateTime CreatedDate { get; }
  int Show();
}