namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public partial interface Frame
{
  /// <summary>
  /// Frame Size.
  /// </summary>
  public String? FrameSize { get; set; }
  
  /// <summary>
  /// Frame Name.
  /// </summary>
  public String? FrameName { get; set; }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? SourceFileReference { get; set; }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  public UInt32? MarginWidth { get; set; }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  public UInt32? MarginHeight { get; set; }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? ScrollbarVisibility { get; set; }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoResizeAllowed { get; set; }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? LinkedToFile { get; set; }
  
}
