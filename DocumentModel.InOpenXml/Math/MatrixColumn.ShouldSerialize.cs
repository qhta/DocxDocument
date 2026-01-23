namespace DocumentModel.Math;

public partial class MatrixColumn
{
  public bool ShouldSerializeMatrixColumnProperties() => MatrixColumnProperties is not null;
}
