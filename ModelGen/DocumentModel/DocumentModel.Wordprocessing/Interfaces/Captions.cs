namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public interface Captions
{
  public DocumentModel.Wordprocessing.Caption? Caption { get ; set; }
  
  public DocumentModel.Wordprocessing.AutoCaptions? AutoCaptions { get ; set; }
  
}
