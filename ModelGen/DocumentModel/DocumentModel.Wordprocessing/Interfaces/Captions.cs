namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public interface Captions
{
  public Caption? Caption { get ; set; }
  
  public AutoCaptions? AutoCaptions { get ; set; }
  
}
