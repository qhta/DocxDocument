namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Frame Properties.
/// </summary>
public partial class Frame
{
  
  /// <summary>
  ///   Frame Size.
  /// </summary>
  public DMW.FrameSize? FrameSize { get; set; }
  
  
  /// <summary>
  ///   Frame Name.
  /// </summary>
  public DMW.FrameName? FrameName { get; set; }
  
  
  /// <summary>
  ///   Source File for Frame.
  /// </summary>
  public DMW.SourceFileReference? SourceFileReference { get; set; }
  
  
  /// <summary>
  ///   Left and Right Margin for Frame.
  /// </summary>
  public DMW.MarginWidth? MarginWidth { get; set; }
  
  
  /// <summary>
  ///   Top and Bottom Margin for Frame.
  /// </summary>
  public DMW.MarginHeight? MarginHeight { get; set; }
  
  
  /// <summary>
  ///   Scrollbar Display Option.
  /// </summary>
  public DMW.FrameScrollbarVisibilityKind? ScrollbarVisibility { get; set; }
  
  
  /// <summary>
  ///   Frame Cannot Be Resized.
  /// </summary>
  public DMW.NoResizeAllowed? NoResizeAllowed { get; set; }
  
  
  /// <summary>
  ///   Maintain Link to Existing File.
  /// </summary>
  public DMW.LinkedToFile? LinkedToFile { get; set; }
  
}
