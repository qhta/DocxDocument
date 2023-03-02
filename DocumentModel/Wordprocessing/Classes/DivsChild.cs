namespace DocumentModel.Wordprocessing;

/// <summary>
///   Child div Elements Contained within Current div.
/// </summary>
public record DivsChild
{
  public Div? Div { get; set; }
}