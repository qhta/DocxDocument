
namespace DocumentModel.Interop.Core;

public partial interface Ruler2: InteropObject
{
  public RulerLevels2 Levels { get; }
  public TabStops2 TabStops { get; }
}
