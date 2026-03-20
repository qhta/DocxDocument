using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface BalloonLabel: InteropObject
{
  string Item { get; }
  string Name { get; }
  string Text { get; set; }
}