namespace DocumentModel.Math;

/// <summary>
/// Matrix Column.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixColumnProperties))]
public interface IMatrixColumn // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public IMatrixColumnProperties? MatrixColumnProperties { get ; set; }
  
}
