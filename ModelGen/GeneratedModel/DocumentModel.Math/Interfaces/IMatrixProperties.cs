namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixColumns))]
[ChildElementInfo(typeof(DocumentModel.Math.IHidePlaceholder))]
[ChildElementInfo(typeof(DocumentModel.Math.IRowSpacingRule))]
[ChildElementInfo(typeof(DocumentModel.Math.IColumnGapRule))]
[ChildElementInfo(typeof(DocumentModel.Math.IColumnSpacing))]
[ChildElementInfo(typeof(DocumentModel.Math.IRowSpacing))]
[ChildElementInfo(typeof(DocumentModel.Math.IColumnGap))]
[ChildElementInfo(typeof(DocumentModel.Math.IBaseJustification))]
public interface IMatrixProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
