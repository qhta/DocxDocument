namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public interface IMatrixColumnProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public System.Int32? MatrixColumnCount { get ; set; }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public DocumentModel.Math.HorizontalAlignmentKind? MatrixColumnJustification { get ; set; }
  
}
