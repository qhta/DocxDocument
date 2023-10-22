namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies information about the current paragraph with regard to text frames. Text frames are paragraphs of text in a document which are positioned in a separate region or frame in the document and can be positioned with a specific size and position relative to non-frame paragraphs in the current document.
/// </summary>
public partial class FrameProperties
{
  
  /// <summary>
  ///   Drop Cap Vertical Height in Lines
  /// </summary>
  public Int32? Lines { get; set; }
  
  
  /// <summary>
  ///   Frame Width
  /// </summary>
  public String? Width { get; set; }
  
  
  /// <summary>
  ///   Frame Height
  /// </summary>
  public UInt32? Height { get; set; }
  
  
  /// <summary>
  ///   Vertical Frame Padding
  /// </summary>
  public String? VerticalSpace { get; set; }
  
  
  /// <summary>
  ///   Horizontal Frame Padding
  /// </summary>
  public String? HorizontalSpace { get; set; }
  
  
  /// <summary>
  ///   Absolute Horizontal Position
  /// </summary>
  public String? X { get; set; }
  
  
  /// <summary>
  ///   Absolute Vertical Position
  /// </summary>
  public String? Y { get; set; }
  
  
  /// <summary>
  ///   Lock Frame Anchor to Paragraph
  /// </summary>
  public Boolean? AnchorLock { get; set; }
  
}
