namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixRow))]
public class Matrix: IMatrix
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public IMatrixProperties? MatrixProperties
  {
    get;
    set;
  }
  
}
