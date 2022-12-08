namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public interface MatrixColumnProperties
{
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public Int32? MatrixColumnCount { get ; set; }
  
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public HorizontalAlignmentKind? MatrixColumnJustification { get ; set; }
  
}
