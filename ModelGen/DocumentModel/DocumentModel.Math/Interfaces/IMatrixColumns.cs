namespace DocumentModel.Math;

/// <summary>
/// Matrix Columns.
/// </summary>
public interface IMatrixColumns // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Math.IMatrixColumn>? MatrixColumns { get ; set; }
  
}
