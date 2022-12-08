namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public interface AutoCaptions
{
  public Collection<AutoCaption>? Items { get ; set; }
  
}
