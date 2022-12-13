namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public interface Fonts
{
  public Collection<DocumentModel.Wordprocessing.Font>? Items { get ; set; }
  
}
