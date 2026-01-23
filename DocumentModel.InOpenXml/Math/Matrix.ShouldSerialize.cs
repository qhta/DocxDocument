namespace DocumentModel.Math;

public partial class Matrix
{
  public bool ShouldSerializeMatrixProperties() => MatrixProperties is not null;
}
