namespace DocumentModel.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public partial interface Captions
{
  public DocumentModel.Wordprocessing.Caption? Caption { get; set; }
  
  public DocumentModel.Wordprocessing.AutoCaptions? AutoCaptions { get; set; }
  
}
