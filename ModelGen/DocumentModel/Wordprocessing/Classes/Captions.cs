namespace DocumentModel.Wordprocessing;


/// <summary>
///   Caption Settings.
/// </summary>
public partial class Captions
{
  public DocumentModel.Wordprocessing.AutoCaptions? AutoCaptions { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.Caption>? Items { get; set; }
  
}
