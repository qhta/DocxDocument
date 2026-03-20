
namespace DocumentModel.Interop.Core;

public interface Ruler2: InteropObject
{
  RulerLevels2 Levels { get; }
  TabStops2 TabStops { get; }
}