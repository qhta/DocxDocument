namespace DocumentModel.Math;


/// <summary>
///   Matrix Properties.
/// </summary>
public partial class MatrixProperties
{
  
  /// <summary>
  ///   Matrix Base Justification.
  /// </summary>
  public DMM.VerticalAlignmentKind? BaseJustification { get; set; }
  
  
  /// <summary>
  ///   Hide Placeholders (Matrix).
  /// </summary>
  public DMM.HidePlaceholder? HidePlaceholder { get; set; }
  
  
  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public DMM.RowSpacingRule? RowSpacingRule { get; set; }
  
  
  /// <summary>
  ///   Matrix Column Gap Rule.
  /// </summary>
  public DMM.ColumnGapRule? ColumnGapRule { get; set; }
  
  
  /// <summary>
  ///   Row Spacing (Matrix).
  /// </summary>
  public DMM.RowSpacing? RowSpacing { get; set; }
  
  
  /// <summary>
  ///   Matrix Column Spacing.
  /// </summary>
  public DMM.ColumnSpacing? ColumnSpacing { get; set; }
  
  
  /// <summary>
  ///   Matrix Column Gap.
  /// </summary>
  public DMM.ColumnGap? ColumnGap { get; set; }
  
  
  /// <summary>
  ///   Matrix Columns.
  /// </summary>
  public DMM.MatrixColumns? MatrixColumns { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DMM.ControlProperties? ControlProperties { get; set; }
  
}
