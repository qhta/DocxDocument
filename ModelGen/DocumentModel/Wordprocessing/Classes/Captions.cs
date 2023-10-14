namespace DocumentModel.Wordprocessing;


/// <summary>
///   Caption Settings.
/// </summary>
public partial class Captions
{
  public DocumentModel.Wordprocessing.AutoCaptions? AutoCaptions { get; set; }
  
  public DM.ElementCollection<Caption>? Items { get; set; }
  
}
