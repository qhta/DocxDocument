namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CommentProperties Class.
/// </summary>
public interface ICommentProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// locked
  /// </summary>
  public Boolean? Locked { get ; set; }
  
  /// <summary>
  /// defaultSize
  /// </summary>
  public Boolean? DefaultSize { get ; set; }
  
  /// <summary>
  /// print
  /// </summary>
  public Boolean? Print { get ; set; }
  
  /// <summary>
  /// disabled
  /// </summary>
  public Boolean? Disabled { get ; set; }
  
  /// <summary>
  /// uiObject
  /// </summary>
  public Boolean? UiObject { get ; set; }
  
  /// <summary>
  /// autoFill
  /// </summary>
  public Boolean? AutoFill { get ; set; }
  
  /// <summary>
  /// autoLine
  /// </summary>
  public Boolean? AutoLine { get ; set; }
  
  /// <summary>
  /// altText
  /// </summary>
  public String? AltText { get ; set; }
  
  /// <summary>
  /// textHAlign
  /// </summary>
  public TextHorizontalAlignmentKind? TextHAlign { get ; set; }
  
  /// <summary>
  /// textVAlign
  /// </summary>
  public TextVerticalAlignmentKind? TextVAlign { get ; set; }
  
  /// <summary>
  /// lockText
  /// </summary>
  public Boolean? LockText { get ; set; }
  
  /// <summary>
  /// justLastX
  /// </summary>
  public Boolean? JustLastX { get ; set; }
  
  /// <summary>
  /// autoScale
  /// </summary>
  public Boolean? AutoScale { get ; set; }
  
  /// <summary>
  /// rowHidden
  /// </summary>
  public Boolean? RowHidden { get ; set; }
  
  /// <summary>
  /// colHidden
  /// </summary>
  public Boolean? ColHidden { get ; set; }
  
  /// <summary>
  /// ObjectAnchor.
  /// </summary>
  public IObjectAnchor? ObjectAnchor { get ; set; }
  
}
