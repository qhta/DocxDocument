using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ThemeFont: InteropObject
{
  public string Name { get; set; }
}
