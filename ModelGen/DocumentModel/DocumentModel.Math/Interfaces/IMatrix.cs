namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public interface IMatrix // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public DocumentModel.Math.IMatrixProperties? MatrixProperties { get ; set; }
  
}
