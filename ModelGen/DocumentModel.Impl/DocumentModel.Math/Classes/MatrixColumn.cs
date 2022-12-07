namespace DocumentModel.Math;

/// <summary>
/// Matrix Column.
/// </summary>
public class MatrixColumnImpl: ModelElement<DocumentFormat.OpenXml.Math.MatrixColumn>, MatrixColumn
{
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public MatrixColumnProperties? MatrixColumnProperties
  {
    get;
    set;
  }
  
}
