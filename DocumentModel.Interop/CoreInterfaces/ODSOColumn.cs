
namespace DocumentModel.Interop.Core;

public interface ODSOColumn: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  int Index { get; }
  string Name { get; }
  object Parent { get; }
  string Value { get; }
}