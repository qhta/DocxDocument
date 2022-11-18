namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CommentProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IObjectAnchor))]
public interface ICommentProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// locked
  /// </summary>
  public bool? Locked { get ; set; }
  
  /// <summary>
  /// defaultSize
  /// </summary>
  public bool? DefaultSize { get ; set; }
  
  /// <summary>
  /// print
  /// </summary>
  public bool? Print { get ; set; }
  
  /// <summary>
  /// disabled
  /// </summary>
  public bool? Disabled { get ; set; }
  
  /// <summary>
  /// uiObject
  /// </summary>
  public bool? UiObject { get ; set; }
  
  /// <summary>
  /// autoFill
  /// </summary>
  public bool? AutoFill { get ; set; }
  
  /// <summary>
  /// autoLine
  /// </summary>
  public bool? AutoLine { get ; set; }
  
  /// <summary>
  /// altText
  /// </summary>
  public string? AltText { get ; set; }
  
  /// <summary>
  /// textHAlign
  /// </summary>
  public DocumentModel.Spreadsheet.TextHorizontalAlignment? TextHAlign { get ; set; }
  
  /// <summary>
  /// textVAlign
  /// </summary>
  public DocumentModel.Spreadsheet.TextVerticalAlignment? TextVAlign { get ; set; }
  
  /// <summary>
  /// lockText
  /// </summary>
  public bool? LockText { get ; set; }
  
  /// <summary>
  /// justLastX
  /// </summary>
  public bool? JustLastX { get ; set; }
  
  /// <summary>
  /// autoScale
  /// </summary>
  public bool? AutoScale { get ; set; }
  
  /// <summary>
  /// rowHidden
  /// </summary>
  public bool? RowHidden { get ; set; }
  
  /// <summary>
  /// colHidden
  /// </summary>
  public bool? ColHidden { get ; set; }
  
  /// <summary>
  /// ObjectAnchor.
  /// </summary>
  public IObjectAnchor? ObjectAnchor { get ; set; }
  
}
