namespace DocumentModel.Presentation;

/// <summary>
/// Normal View Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRestoredLeft))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRestoredTop))]
public interface INormalViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Outline Icons in Normal View
  /// </summary>
  public bool? ShowOutlineIcons { get ; set; }
  
  /// <summary>
  /// Snap Vertical Splitter
  /// </summary>
  public bool? SnapVerticalSplitter { get ; set; }
  
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
  public bool? PreferSingleView { get ; set; }
  
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
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
