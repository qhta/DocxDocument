namespace DocumentModel.Wordprocessing;


/// <summary>
///   Caption Settings.
/// </summary>
public partial class Captions
{
  public AutoCaptions? AutoCaptions { get; set; }
  
  public ElementCollection<Caption>? Items { get; set; }
  
}
