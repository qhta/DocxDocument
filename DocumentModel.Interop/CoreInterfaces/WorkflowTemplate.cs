
namespace DocumentModel.Interop.Core;

public interface WorkflowTemplate: InteropObject
{
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string DocumentLibraryName { get; }
  string DocumentLibraryURL { get; }
  int Show();
}