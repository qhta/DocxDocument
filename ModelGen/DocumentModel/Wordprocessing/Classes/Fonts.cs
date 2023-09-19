namespace DocumentModel.Wordprocessing;


/// <summary>
///   Font Table Root Element.
/// </summary>
public partial class Fonts
{
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.Font>? Items { get; set; }
  
}
