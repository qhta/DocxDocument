namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the matrix column mn, including the number of columns and the type of justification.
/// </summary>
public class MatrixColumnProperties: ModelElement
{
  /// <summary>
  ///   Matrix IColumn Count.
  /// </summary>
  public Int32? MatrixColumnCount { get; set; }
  /// <summary>
  ///   Matrix IColumn Justification.
  /// </summary>
  public HorizontalAlignmentKind? MatrixColumnJustification { get; set; }
}