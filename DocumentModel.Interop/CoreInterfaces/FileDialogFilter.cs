
namespace DocumentModel.Interop.Core;

public interface FileDialogFilter: InteropObject
{
  public string Extensions { get; }
  public string Description { get; }
}
