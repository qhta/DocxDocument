namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public interface IMatrixProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public IBaseJustification? BaseJustification { get ; set; }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public IHidePlaceholder? HidePlaceholder { get ; set; }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public IRowSpacingRule? RowSpacingRule { get ; set; }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  public IColumnGapRule? ColumnGapRule { get ; set; }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  public IRowSpacing? RowSpacing { get ; set; }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  public IColumnSpacing? ColumnSpacing { get ; set; }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  public IColumnGap? ColumnGap { get ; set; }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public IMatrixColumns? MatrixColumns { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
