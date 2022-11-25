namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public interface IMatrixProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public DocumentModel.Math.VerticalAlignmentKind? BaseJustification { get ; set; }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public DocumentModel.Math.BooleanKind? HidePlaceholder { get ; set; }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public System.Int32? RowSpacingRule { get ; set; }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  public System.Int32? ColumnGapRule { get ; set; }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  public System.UInt16? RowSpacing { get ; set; }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  public System.UInt32? ColumnSpacing { get ; set; }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  public System.UInt16? ColumnGap { get ; set; }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? MatrixColumns { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ControlProperties { get ; set; }
  
}
