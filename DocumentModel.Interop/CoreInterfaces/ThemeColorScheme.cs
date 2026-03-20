using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeColorScheme: InteropCollection<ThemeColor>
{
  ThemeColor Colors(MsoThemeColorSchemeIndex Index);
  void Load(string FileName);
  void Save(string FileName);
  int GetCustomColor(string Name);
}