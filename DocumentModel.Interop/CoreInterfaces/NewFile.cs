
namespace DocumentModel.Interop.Core;

public interface NewFile: InteropObject
{
  bool Add(string FileName, object Section, object DisplayName, object Action);
  bool Remove(string FileName, object Section, object DisplayName, object Action);
}