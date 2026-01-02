namespace DocumentModel.Math;
/// <summary>
///   This element specifies a single column in a matrix.
/// </summary>
public class MatrixColumn: ModelElement
{
  /// <summary>
  ///   Matrix IColumn Properties.
  /// </summary>
  public MatrixColumnProperties? MatrixColumnProperties { get; set; }
}