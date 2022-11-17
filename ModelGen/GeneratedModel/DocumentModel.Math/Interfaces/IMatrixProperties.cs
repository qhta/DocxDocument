namespace DocumentModel.Math;

public interface IMatrixProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IBaseJustification? BaseJustification { get ; set; }

  public IHidePlaceholder? HidePlaceholder { get ; set; }

  public IRowSpacingRule? RowSpacingRule { get ; set; }

  public IColumnGapRule? ColumnGapRule { get ; set; }

  public IRowSpacing? RowSpacing { get ; set; }

  public IColumnSpacing? ColumnSpacing { get ; set; }

  public IColumnGap? ColumnGap { get ; set; }

  public IMatrixColumns? MatrixColumns { get ; set; }

  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }

}
