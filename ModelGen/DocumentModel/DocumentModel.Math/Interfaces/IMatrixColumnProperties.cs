namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixColumnCount))]
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixColumnJustification))]
public interface IMatrixColumnProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
