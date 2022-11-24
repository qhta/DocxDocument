namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public interface IMatrix // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public IMatrixProperties? MatrixProperties { get ; set; }
  
}
