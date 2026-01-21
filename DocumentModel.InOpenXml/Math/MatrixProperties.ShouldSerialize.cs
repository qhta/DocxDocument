namespace DocumentModel.Math;

public partial class MatrixProperties
{
  public bool ShouldSerializeBaseJustification() => BaseJustification is not null;
  public bool ShouldSerializeHidePlaceholder() => HidePlaceholder is not null;
  public bool ShouldSerializeRowSpacing() => RowSpacing is not null;
  public bool ShouldSerializeColumnGapRule() => ColumnGapRule is not null;
  public bool ShouldSerializeColumnSpacing() => ColumnSpacing is not null;
  public bool ShouldSerializeColumnGap() => ColumnGap is not null;
  public bool ShouldSerializeMatrixColumns() => MatrixColumns is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
