namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class MatrixColumn
{
  public bool ShouldSerializeMatrixColumnProperties() => MatrixColumnProperties is not null;
}
