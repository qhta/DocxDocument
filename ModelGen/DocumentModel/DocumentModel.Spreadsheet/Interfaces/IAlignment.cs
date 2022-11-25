namespace DocumentModel.Spreadsheet;

/// <summary>
/// Alignment.
/// </summary>
public interface IAlignment // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Alignment
  /// </summary>
  public DocumentModel.Spreadsheet.HorizontalAlignmentKind? Horizontal { get ; set; }
  
  /// <summary>
  /// Vertical Alignment
  /// </summary>
  public DocumentModel.Spreadsheet.VerticalAlignmentKind? Vertical { get ; set; }
  
  /// <summary>
  /// Text Rotation
  /// </summary>
  public System.UInt32? TextRotation { get ; set; }
  
  /// <summary>
  /// Wrap Text
  /// </summary>
  public System.Boolean? WrapText { get ; set; }
  
  /// <summary>
  /// Indent
  /// </summary>
  public System.UInt32? Indent { get ; set; }
  
  /// <summary>
  /// Relative Indent
  /// </summary>
  public System.Int32? RelativeIndent { get ; set; }
  
  /// <summary>
  /// Justify Last Line
  /// </summary>
  public System.Boolean? JustifyLastLine { get ; set; }
  
  /// <summary>
  /// Shrink To Fit
  /// </summary>
  public System.Boolean? ShrinkToFit { get ; set; }
  
  /// <summary>
  /// Reading Order
  /// </summary>
  public System.UInt32? ReadingOrder { get ; set; }
  
  /// <summary>
  /// mergeCell
  /// </summary>
  public System.String? MergeCell { get ; set; }
  
}
