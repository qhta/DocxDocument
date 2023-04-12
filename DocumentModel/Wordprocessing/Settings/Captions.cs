namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Caption Settings.
/// </summary>
public class Captions: ModelElement
{
  public Caption? Caption { get; set; }

  public AutoCaptions? AutoCaptions { get; set; }
}