namespace DocumentModel.Presentation;

/// <summary>
/// Normal View Properties.
/// </summary>
public interface INormalViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Outline Icons in Normal View
  /// </summary>
  public System.Boolean? ShowOutlineIcons { get ; set; }
  
  /// <summary>
  /// Snap Vertical Splitter
  /// </summary>
  public System.Boolean? SnapVerticalSplitter { get ; set; }
  
  /// <summary>
  /// State of the Vertical Splitter Bar
  /// </summary>
  public DocumentModel.Presentation.SplitterBarStateKind? VerticalBarState { get ; set; }
  
  /// <summary>
  /// State of the Horizontal Splitter Bar
  /// </summary>
  public DocumentModel.Presentation.SplitterBarStateKind? HorizontalBarState { get ; set; }
  
  /// <summary>
  /// Prefer Single View
  /// </summary>
  public System.Boolean? PreferSingleView { get ; set; }
  
  /// <summary>
  /// Normal View Restored Left Properties.
  /// </summary>
  public DocumentModel.Presentation.INormalViewPortionType? RestoredLeft { get ; set; }
  
  /// <summary>
  /// Normal View Restored Top Properties.
  /// </summary>
  public DocumentModel.Presentation.INormalViewPortionType? RestoredTop { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
