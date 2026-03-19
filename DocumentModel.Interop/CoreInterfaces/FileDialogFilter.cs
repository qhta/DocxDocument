
namespace DocumentModel.Interop.Core;

public interface FileDialogFilter: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Extensions { get; }
  string Description { get; }
}