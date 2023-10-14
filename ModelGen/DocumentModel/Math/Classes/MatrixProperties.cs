namespace DocumentModel.Math;


/// <summary>
///   Matrix Properties.
/// </summary>
public partial class MatrixProperties
{
  
  /// <summary>
  ///   Matrix Base Justification.
  /// </summary>
  public DocumentModel.Math.VerticalAlignmentKind? BaseJustification { get; set; }
  
  
  /// <summary>
  ///   Hide Placeholders (Matrix).
  /// </summary>
  public DocumentModel.Math.HidePlaceholder? HidePlaceholder { get; set; }
  
  
  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public DocumentModel.Math.RowSpacingRule? RowSpacingRule { get; set; }
  
  
  /// <summary>
  ///   Matrix Column Gap Rule.
  /// </summary>
  public DocumentModel.Math.ColumnGapRule? ColumnGapRule { get; set; }
  
  
  /// <summary>
  ///   Row Spacing (Matrix).
  /// </summary>
  public DocumentModel.Math.RowSpacing? RowSpacing { get; set; }
  
  
  /// <summary>
  ///   Matrix Column Spacing.
  /// </summary>
  public DocumentModel.Math.ColumnSpacing? ColumnSpacing { get; set; }
  
  
  /// <summary>
  ///   Matrix Column Gap.
  /// </summary>
  public DocumentModel.Math.ColumnGap? ColumnGap { get; set; }
  
  
  /// <summary>
  ///   Matrix Columns.
  /// </summary>
  public DocumentModel.Math.MatrixColumns? MatrixColumns { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
