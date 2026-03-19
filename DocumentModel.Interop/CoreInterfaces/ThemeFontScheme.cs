
namespace DocumentModel.Interop.Core;

public interface ThemeFontScheme: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void Load(string FileName);
  void Save(string FileName);
  ThemeFonts MinorFont { get; }
  ThemeFonts MajorFont { get; }
}