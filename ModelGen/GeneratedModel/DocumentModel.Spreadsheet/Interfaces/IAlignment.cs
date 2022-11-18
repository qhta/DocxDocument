namespace DocumentModel.Spreadsheet;

/// <summary>
/// Alignment.
/// </summary>
public interface IAlignment // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Alignment
  /// </summary>
  public DocumentModel.Spreadsheet.HorizontalAlignment? Horizontal { get ; set; }
  
  /// <summary>
  /// Vertical Alignment
  /// </summary>
  public DocumentModel.Spreadsheet.VerticalAlignment? Vertical { get ; set; }
  
  /// <summary>
  /// Text Rotation
  /// </summary>
  public uint? TextRotation { get ; set; }
  
  /// <summary>
  /// Wrap Text
  /// </summary>
  public bool? WrapText { get ; set; }
  
  /// <summary>
  /// Indent
  /// </summary>
  public uint? Indent { get ; set; }
  
  /// <summary>
  /// Relative Indent
  /// </summary>
  public int? RelativeIndent { get ; set; }
  
  /// <summary>
  /// Justify Last Line
  /// </summary>
  public bool? JustifyLastLine { get ; set; }
  
  /// <summary>
  /// Shrink To Fit
  /// </summary>
  public bool? ShrinkToFit { get ; set; }
  
  /// <summary>
  /// Reading Order
  /// </summary>
  public uint? ReadingOrder { get ; set; }
  
  /// <summary>
  /// mergeCell
  /// </summary>
  public string? MergeCell { get ; set; }
  
}
