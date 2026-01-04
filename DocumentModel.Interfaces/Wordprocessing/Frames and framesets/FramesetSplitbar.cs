namespace DocumentModel.Wordprocessing;
/// <summary>
///   Frameset Splitter Properties.
/// </summary>
public interface FramesetSplitbar: IModelElement
{
  /// <summary>
  ///   Frameset Splitter Width.
  /// </summary>
  public Twips? Width { get; set; }
  /// <summary>
  ///   Frameset Splitter Color.
  /// </summary>
  public DM.IColor? Color { get; set; }
  /// <summary>
  ///   Do Not Display Frameset Splitters.
  /// </summary>
  public bool? NoBorder { get; set; }
  /// <summary>
  ///   Frameset Splitter Border Style.
  /// </summary>
  public bool? FlatBorders { get; set; }
}