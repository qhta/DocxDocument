
namespace DocumentModel.Interop.Core;

public interface ODSOColumn: InteropObject
{
  int Index { get; }
  string Name { get; }
  string Value { get; }
}