namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public partial class MatrixColumnProperties
{
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public Int64? MatrixColumnCount { get; set; }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public DocumentModel.Math.HorizontalAlignmentKind? MatrixColumnJustification { get; set; }
  
}
