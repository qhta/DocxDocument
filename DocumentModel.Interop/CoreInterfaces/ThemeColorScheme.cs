using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeColorScheme: InteropObject, IEnumerable
{
  int Count { get; }
  ThemeColor Colors(MsoThemeColorSchemeIndex Index);
  new IEnumerator GetEnumerator();
  void Load(string FileName);
  void Save(string FileName);
  int GetCustomColor(string Name);
}