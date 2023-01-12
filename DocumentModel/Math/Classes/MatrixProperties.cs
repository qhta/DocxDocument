namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public partial class MatrixProperties
{
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public DocumentModel.Math.VerticalAlignmentKind? BaseJustification { get; set; }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public DocumentModel.Math.BooleanKind? HidePlaceholder { get; set; }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public Int64? RowSpacingRule { get; set; }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  public Int64? ColumnGapRule { get; set; }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  public UInt16? RowSpacing { get; set; }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  public UInt32? ColumnSpacing { get; set; }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  public UInt16? ColumnGap { get; set; }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public DocumentModel.Math.MatrixColumns? MatrixColumns { get; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
