namespace DocumentModel.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public partial interface DivsChild
{
  public DocumentModel.Wordprocessing.Div? Div { get; set; }
  
}
