namespace DocumentModel.Wordprocessing;

/// <summary>
///   Automatic Captioning Settings.
/// </summary>
public record AutoCaptions
{
  public AutoCaption? AutoCaption { get; set; }
}