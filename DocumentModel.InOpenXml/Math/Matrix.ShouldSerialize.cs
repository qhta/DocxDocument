namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class Matrix
{
  public bool ShouldSerializeMatrixProperties() => MatrixProperties is not null;
}
