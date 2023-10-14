namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Frame Properties.
/// </summary>
public partial class Frame
{
  
  /// <summary>
  ///   Frame Size.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameSize? FrameSize { get; set; }
  
  
  /// <summary>
  ///   Frame Name.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameName? FrameName { get; set; }
  
  
  /// <summary>
  ///   Source File for Frame.
  /// </summary>
  public DocumentModel.Wordprocessing.SourceFileReference? SourceFileReference { get; set; }
  
  
  /// <summary>
  ///   Left and Right Margin for Frame.
  /// </summary>
  public DocumentModel.Wordprocessing.MarginWidth? MarginWidth { get; set; }
  
  
  /// <summary>
  ///   Top and Bottom Margin for Frame.
  /// </summary>
  public DocumentModel.Wordprocessing.MarginHeight? MarginHeight { get; set; }
  
  
  /// <summary>
  ///   Scrollbar Display Option.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? ScrollbarVisibility { get; set; }
  
  
  /// <summary>
  ///   Frame Cannot Be Resized.
  /// </summary>
  public DocumentModel.Wordprocessing.NoResizeAllowed? NoResizeAllowed { get; set; }
  
  
  /// <summary>
  ///   Maintain Link to Existing File.
  /// </summary>
  public DocumentModel.Wordprocessing.LinkedToFile? LinkedToFile { get; set; }
  
}
