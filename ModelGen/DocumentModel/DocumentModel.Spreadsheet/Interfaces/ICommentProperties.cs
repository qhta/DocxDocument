namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CommentProperties Class.
/// </summary>
public interface ICommentProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// locked
  /// </summary>
  public System.Boolean? Locked { get ; set; }
  
  /// <summary>
  /// defaultSize
  /// </summary>
  public System.Boolean? DefaultSize { get ; set; }
  
  /// <summary>
  /// print
  /// </summary>
  public System.Boolean? Print { get ; set; }
  
  /// <summary>
  /// disabled
  /// </summary>
  public System.Boolean? Disabled { get ; set; }
  
  /// <summary>
  /// uiObject
  /// </summary>
  public System.Boolean? UiObject { get ; set; }
  
  /// <summary>
  /// autoFill
  /// </summary>
  public System.Boolean? AutoFill { get ; set; }
  
  /// <summary>
  /// autoLine
  /// </summary>
  public System.Boolean? AutoLine { get ; set; }
  
  /// <summary>
  /// altText
  /// </summary>
  public System.String? AltText { get ; set; }
  
  /// <summary>
  /// textHAlign
  /// </summary>
  public DocumentModel.Spreadsheet.TextHorizontalAlignmentKind? TextHAlign { get ; set; }
  
  /// <summary>
  /// textVAlign
  /// </summary>
  public DocumentModel.Spreadsheet.TextVerticalAlignmentKind? TextVAlign { get ; set; }
  
  /// <summary>
  /// lockText
  /// </summary>
  public System.Boolean? LockText { get ; set; }
  
  /// <summary>
  /// justLastX
  /// </summary>
  public System.Boolean? JustLastX { get ; set; }
  
  /// <summary>
  /// autoScale
  /// </summary>
  public System.Boolean? AutoScale { get ; set; }
  
  /// <summary>
  /// rowHidden
  /// </summary>
  public System.Boolean? RowHidden { get ; set; }
  
  /// <summary>
  /// colHidden
  /// </summary>
  public System.Boolean? ColHidden { get ; set; }
  
  /// <summary>
  /// ObjectAnchor.
  /// </summary>
  public DocumentModel.Spreadsheet.IObjectAnchor? ObjectAnchor { get ; set; }
  
}
