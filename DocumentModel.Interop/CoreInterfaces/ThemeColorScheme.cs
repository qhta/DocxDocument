using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeColorScheme: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  ThemeColor Colors(MsoThemeColorSchemeIndex Index);
  new IEnumerator GetEnumerator();
  void Load(string FileName);
  void Save(string FileName);
  int GetCustomColor(string Name);
}