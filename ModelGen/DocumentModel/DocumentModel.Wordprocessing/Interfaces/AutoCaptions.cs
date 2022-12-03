namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public interface AutoCaptions // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<AutoCaption>? AutoCaptions { get ; set; }
  
}
