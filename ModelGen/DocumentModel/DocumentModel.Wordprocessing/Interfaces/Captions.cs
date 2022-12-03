namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public interface Captions // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Caption>? Captions { get ; set; }
  
  public AutoCaptions? AutoCaptions { get ; set; }
  
}
