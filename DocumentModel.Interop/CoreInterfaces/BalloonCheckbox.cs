using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface BalloonCheckbox: InteropObject
{
  string Item { get; }
  string Name { get; }
  bool Checked { get; set; }
  string Text { get; set; }
}