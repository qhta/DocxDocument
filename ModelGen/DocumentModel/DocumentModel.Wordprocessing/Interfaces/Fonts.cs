namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public partial interface Fonts
{
  public Collection<DocumentModel.Wordprocessing.Font>? Items { get; set; }
  
}
