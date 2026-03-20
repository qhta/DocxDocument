
namespace DocumentModel.Interop.Core;

public partial interface ODSOColumn: InteropObject
{
  public int Index { get; }
  public string Name { get; }
  public string Value { get; }
}
