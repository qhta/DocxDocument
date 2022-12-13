namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
public interface FramesetSplitbar
{
  /// <summary>
  /// Frameset Splitter Width.
  /// </summary>
  public String? Width { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  public DocumentModel.Wordprocessing.Color? Color { get ; set; }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoBorder { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? FlatBorders { get ; set; }
  
}
