
namespace DocumentModel.Interop.Core;

public interface FileDialogFilter: InteropObject
{
  string Extensions { get; }
  string Description { get; }
}