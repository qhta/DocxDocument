using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface BalloonLabel: InteropObject
{
  public string Item { get; }
  public string Name { get; }
  public string Text { get; set; }
}
