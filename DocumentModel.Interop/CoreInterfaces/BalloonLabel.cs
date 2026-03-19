using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface BalloonLabel: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Item { get; }
  string Name { get; }
  object Parent { get; }
  string Text { get; set; }
}