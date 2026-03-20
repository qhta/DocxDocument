
namespace DocumentModel.Interop.Core;

public interface NewFile: InteropObject
{
  public bool Add(string FileName, object Section, object DisplayName, object Action);
  public bool Remove(string FileName, object Section, object DisplayName, object Action);
}
