namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public interface IFrame // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Frame Size.
  /// </summary>
  public IFrameSize? FrameSize { get ; set; }
  
  /// <summary>
  /// Frame Name.
  /// </summary>
  public IFrameName? FrameName { get ; set; }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  public ISourceFileReference? SourceFileReference { get ; set; }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  public IMarginWidth? MarginWidth { get ; set; }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  public IMarginHeight? MarginHeight { get ; set; }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues>? ScrollbarVisibility { get ; set; }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  public INoResizeAllowed? NoResizeAllowed { get ; set; }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  public ILinkedToFile? LinkedToFile { get ; set; }
  
}
