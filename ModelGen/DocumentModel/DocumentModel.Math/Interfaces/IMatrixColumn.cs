namespace DocumentModel.Math;

/// <summary>
/// Matrix Column.
/// </summary>
public interface IMatrixColumn // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public IMatrixColumnProperties? MatrixColumnProperties { get ; set; }
  
}
