
namespace DocumentModel.Interop.Core;

public interface ODSOColumns: InteropObject
{
  int Count { get; }
  object Item(object varIndex);
}