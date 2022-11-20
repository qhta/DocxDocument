namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixColumnCount))]
[ChildElementInfo(typeof(DocumentModel.Math.IMatrixColumnJustification))]
public class MatrixColumnProperties: IMatrixColumnProperties
{
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public IMatrixColumnCount? MatrixColumnCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public IMatrixColumnJustification? MatrixColumnJustification
  {
    get;
    set;
  }
  
}
