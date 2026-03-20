using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface HTMLProjectItem: InteropObject
{
  public string Name { get; }
  public bool IsOpen { get; }
  public string Text { get; set; }
}
