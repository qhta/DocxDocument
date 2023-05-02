namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Frameset Splitter Properties.
/// </summary>
public class FramesetSplitbar: ModelElement
{
  /// <summary>
  ///   Frameset Splitter Width.
  /// </summary>
  public string? Width { get; set; }

  /// <summary>
  ///   Frameset Splitter Color.
  /// </summary>
  public Color? Color { get; set; }

  /// <summary>
  ///   Do Not Display Frameset Splitters.
  /// </summary>
  public bool? NoBorder { get; set; }

  /// <summary>
  ///   Frameset Splitter Border Style.
  /// </summary>
  public bool? FlatBorders { get; set; }
}