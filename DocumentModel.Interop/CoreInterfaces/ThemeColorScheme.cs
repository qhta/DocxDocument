using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeColorScheme: InteropCollection<ThemeColor>
{
  public ThemeColor Colors(MsoThemeColorSchemeIndex Index);
  public void Load(string FileName);
  public void Save(string FileName);
  public int GetCustomColor(string Name);
}
