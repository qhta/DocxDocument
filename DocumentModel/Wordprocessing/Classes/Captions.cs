namespace DocumentModel.Wordprocessing;

/// <summary>
///   Caption Settings.
/// </summary>
public record Captions
{
  public Caption? Caption { get; set; }

  public AutoCaptions? AutoCaptions { get; set; }
}