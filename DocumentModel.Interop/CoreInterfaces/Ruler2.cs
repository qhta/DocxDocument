
namespace DocumentModel.Interop.Core;

public interface Ruler2: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  RulerLevels2 Levels { get; }
  TabStops2 TabStops { get; }
}