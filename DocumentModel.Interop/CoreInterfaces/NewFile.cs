
namespace DocumentModel.Interop.Core;

public interface NewFile: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  bool Add(string FileName, object Section, object DisplayName, object Action);
  bool Remove(string FileName, object Section, object DisplayName, object Action);
}