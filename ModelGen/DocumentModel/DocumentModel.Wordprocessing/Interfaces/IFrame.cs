namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public interface IFrame // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Frame Size.
  /// </summary>
  public System.String? FrameSize { get ; set; }
  
  /// <summary>
  /// Frame Name.
  /// </summary>
  public System.String? FrameName { get ; set; }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  public DocumentModel.Wordprocessing.IRelationshipType? SourceFileReference { get ; set; }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  public System.UInt32? MarginWidth { get ; set; }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  public System.UInt32? MarginHeight { get ; set; }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? ScrollbarVisibility { get ; set; }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoResizeAllowed { get ; set; }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? LinkedToFile { get ; set; }
  
}
