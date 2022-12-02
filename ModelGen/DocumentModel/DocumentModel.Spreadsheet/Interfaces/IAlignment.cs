namespace DocumentModel.Spreadsheet;

/// <summary>
/// Alignment.
/// </summary>
public interface IAlignment // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Alignment
  /// </summary>
  public HorizontalAlignmentKind? Horizontal { get ; set; }
  
  /// <summary>
  /// Vertical Alignment
  /// </summary>
  public VerticalAlignmentKind? Vertical { get ; set; }
  
  /// <summary>
  /// Text Rotation
  /// </summary>
  public UInt32? TextRotation { get ; set; }
  
  /// <summary>
  /// Wrap Text
  /// </summary>
  public Boolean? WrapText { get ; set; }
  
  /// <summary>
  /// Indent
  /// </summary>
  public UInt32? Indent { get ; set; }
  
  /// <summary>
  /// Relative Indent
  /// </summary>
  public Int32? RelativeIndent { get ; set; }
  
  /// <summary>
  /// Justify Last Line
  /// </summary>
  public Boolean? JustifyLastLine { get ; set; }
  
  /// <summary>
  /// Shrink To Fit
  /// </summary>
  public Boolean? ShrinkToFit { get ; set; }
  
  /// <summary>
  /// Reading Order
  /// </summary>
  public UInt32? ReadingOrder { get ; set; }
  
  /// <summary>
  /// mergeCell
  /// </summary>
  public String? MergeCell { get ; set; }
  
}
