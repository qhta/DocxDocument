namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BlipFill Class.
/// </summary>
public interface BlipFill1
{
  /// <summary>
  /// Blip.
  /// </summary>
  public Blip? Blip { get ; set; }
  
  public Tile? Tile { get ; set; }
  
  public Stretch? Stretch { get ; set; }
  
}
