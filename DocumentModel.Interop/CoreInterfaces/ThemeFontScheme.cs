
namespace DocumentModel.Interop.Core;

public interface ThemeFontScheme: InteropObject
{
  void Load(string FileName);
  void Save(string FileName);
  ThemeFonts MinorFont { get; }
  ThemeFonts MajorFont { get; }
}