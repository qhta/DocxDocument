namespace DocumentModel.Math;

public partial class MatrixColumnProperties
{
  public bool ShouldSerializeMatrixColumnCount() => MatrixColumnCount is not null;
  public bool ShouldSerializeMatrixColumnJustification() => MatrixColumnJustification is not null;
}
