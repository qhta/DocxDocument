namespace DocumentModel.Math;

/// <summary>
/// Matrix Columns.
/// </summary>
public interface IMatrixColumns // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IMatrixColumn>? MatrixColumns { get ; set; }
  
}
