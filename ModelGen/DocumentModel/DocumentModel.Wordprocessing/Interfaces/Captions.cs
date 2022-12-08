namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public interface Captions
{
  public Collection<Caption>? Items { get ; set; }
  
  public AutoCaptions? AutoCaptions { get ; set; }
  
}
