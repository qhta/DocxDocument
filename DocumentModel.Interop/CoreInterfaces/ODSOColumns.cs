
namespace DocumentModel.Interop.Core;

public interface ODSOColumns: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  int Count { get; }
  object Parent { get; }
  object Item(object varIndex);
}