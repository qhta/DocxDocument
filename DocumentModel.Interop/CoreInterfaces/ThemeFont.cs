using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeFont: InteropObject
{
  string Name { get; set; }
}