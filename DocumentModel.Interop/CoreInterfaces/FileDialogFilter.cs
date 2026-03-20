
namespace DocumentModel.Interop.Core;

public partial interface FileDialogFilter: InteropObject
{
  public string Extensions { get; }
  public string Description { get; }
}
