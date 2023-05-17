namespace DocumentModel.Wordprocessing;

/// <summary>
///   Frameset Splitter Properties.
/// </summary>
public class FramesetSplitbar: ModelElement
{
  /// <summary>
  ///   Frameset Splitter Width.
  /// </summary>
  public Twips? Width { get; set; }

  /// <summary>
  ///   Frameset Splitter Color.
  /// </summary>
  public DM.Color? Color { get; set; }

  /// <summary>
  ///   Do Not Display Frameset Splitters.
  /// </summary>
  public bool? NoBorder { get; set; }

  /// <summary>
  ///   Frameset Splitter Border Style.
  /// </summary>
  public bool? FlatBorders { get; set; }
}