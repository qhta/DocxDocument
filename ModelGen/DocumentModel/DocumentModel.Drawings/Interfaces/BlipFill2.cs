namespace DocumentModel.Drawings;

/// <summary>
/// Picture Fill.
/// </summary>
public interface BlipFill2
{
  /// <summary>
  /// Blip.
  /// </summary>
  public Blip? Blip { get ; set; }
  
  public Tile? Tile { get ; set; }
  
  public Stretch? Stretch { get ; set; }
  
}
