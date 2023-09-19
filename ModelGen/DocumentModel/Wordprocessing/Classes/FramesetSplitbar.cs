namespace DocumentModel.Wordprocessing;


/// <summary>
///   Frameset Splitter Properties.
/// </summary>
public partial class FramesetSplitbar
{
  
  /// <summary>
  ///   Frameset Splitter Width.
  /// </summary>
  public String? Width { get; set; }
  
  
  /// <summary>
  ///   Frameset Splitter Color.
  /// </summary>
  public DocumentModel.Wordprocessing.Color? Color { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Frameset Splitters.
  /// </summary>
  public Boolean? NoBorder { get; set; }
  
  
  /// <summary>
  ///   Frameset Splitter Border Style.
  /// </summary>
  public Boolean? FlatBorders { get; set; }
  
}
