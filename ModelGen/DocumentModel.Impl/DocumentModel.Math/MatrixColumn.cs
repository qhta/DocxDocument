namespace DocumentModel.Math;

/// <summary>
/// Matrix Column.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixColumnProperties))]
public class MatrixColumn: IMatrixColumn
{
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public IMatrixColumnProperties? MatrixColumnProperties
  {
    get;
    set;
  }
  
}
