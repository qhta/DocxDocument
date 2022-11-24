namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public interface IMatrixColumnProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public IMatrixColumnCount? MatrixColumnCount { get ; set; }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public IMatrixColumnJustification? MatrixColumnJustification { get ; set; }
  
}
