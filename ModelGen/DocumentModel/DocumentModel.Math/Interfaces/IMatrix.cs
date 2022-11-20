namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixRow))]
public interface IMatrix // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public IMatrixProperties? MatrixProperties { get ; set; }
  
}
