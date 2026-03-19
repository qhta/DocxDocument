
namespace DocumentModel.Interop.Core;

public interface WorkflowTemplate: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Id { get; }
  string Name { get; }
  string Description { get; }
  string DocumentLibraryName { get; }
  string DocumentLibraryURL { get; }
  int Show();
}