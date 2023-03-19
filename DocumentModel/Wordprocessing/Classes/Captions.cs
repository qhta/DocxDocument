namespace DocumentModel.Wordprocessing;

/// <summary>
///   Caption Settings.
/// </summary>
public class Captions: ModelElement
{
  public Caption? Caption { get; set; }

  public AutoCaptions? AutoCaptions { get; set; }
}