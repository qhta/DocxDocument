
namespace DocumentModel.Interop.Core;

public interface ThemeEffectScheme: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void Load(string FileName);
}