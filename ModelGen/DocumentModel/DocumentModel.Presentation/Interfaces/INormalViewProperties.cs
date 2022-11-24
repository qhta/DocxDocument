namespace DocumentModel.Presentation;

/// <summary>
/// Normal View Properties.
/// </summary>
public interface INormalViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Outline Icons in Normal View
  /// </summary>
  public Boolean? ShowOutlineIcons { get ; set; }
  
  /// <summary>
  /// Snap Vertical Splitter
  /// </summary>
  public Boolean? SnapVerticalSplitter { get ; set; }
  
  /// <summary>
  /// State of the Vertical Splitter Bar
  /// </summary>
  public SplitterBarStateValues? VerticalBarState { get ; set; }
  
  /// <summary>
  /// State of the Horizontal Splitter Bar
  /// </summary>
  public SplitterBarStateValues? HorizontalBarState { get ; set; }
  
  /// <summary>
  /// Prefer Single View
  /// </summary>
  public Boolean? PreferSingleView { get ; set; }
  
  /// <summary>
  /// Normal View Restored Left Properties.
  /// </summary>
  public IRestoredLeft? RestoredLeft { get ; set; }
  
  /// <summary>
  /// Normal View Restored Top Properties.
  /// </summary>
  public IRestoredTop? RestoredTop { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
