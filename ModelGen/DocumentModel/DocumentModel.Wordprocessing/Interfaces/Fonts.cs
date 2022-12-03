namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public interface Fonts // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Font>? Fonts { get ; set; }
  
}
