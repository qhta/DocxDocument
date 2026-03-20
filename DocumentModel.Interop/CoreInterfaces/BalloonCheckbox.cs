using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface BalloonCheckbox: InteropObject
{
  public string Item { get; }
  public string Name { get; }
  public bool Checked { get; set; }
  public string Text { get; set; }
}
