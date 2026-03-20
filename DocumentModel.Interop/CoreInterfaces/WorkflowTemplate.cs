
namespace DocumentModel.Interop.Core;

public partial interface WorkflowTemplate: InteropObject
{
  public string Id { get; }
  public string Name { get; }
  public string Description { get; }
  public string DocumentLibraryName { get; }
  public string DocumentLibraryURL { get; }
}
