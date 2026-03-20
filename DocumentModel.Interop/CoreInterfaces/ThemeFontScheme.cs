
namespace DocumentModel.Interop.Core;

public interface ThemeFontScheme: InteropObject
{
  public void Load(string FileName);
  public void Save(string FileName);
  public ThemeFonts MinorFont { get; }
  public ThemeFonts MajorFont { get; }
}
