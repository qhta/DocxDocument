using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface BalloonCheckbox: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Item { get; }
  string Name { get; }
  object Parent { get; }
  bool Checked { get; set; }
  string Text { get; set; }
}