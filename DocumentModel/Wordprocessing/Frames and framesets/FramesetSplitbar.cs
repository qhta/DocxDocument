namespace DocumentModel.Wordprocessing;

/// <summary>
///   IFrameset Splitter Properties.
/// </summary>
public class FramesetSplitbar: ModelElement
{
  /// <summary>
  ///   IFrameset Splitter Width.
  /// </summary>
  public Twips? Width { get; set; }

  /// <summary>
  ///   IFrameset Splitter Color.
  /// </summary>
  public DM.Color? Color { get; set; }

  /// <summary>
  ///   Do Not Display IFrameset Splitters.
  /// </summary>
  public bool? NoBorder { get; set; }

  /// <summary>
  ///   IFrameset Splitter IBorder IStyle.
  /// </summary>
  public bool? FlatBorders { get; set; }
}
