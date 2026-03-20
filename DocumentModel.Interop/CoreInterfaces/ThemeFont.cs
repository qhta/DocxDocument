using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface ThemeFont: InteropObject
{
  public string Name { get; set; }
}
