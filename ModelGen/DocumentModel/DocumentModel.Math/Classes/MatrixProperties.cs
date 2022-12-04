namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public class MatrixProperties
{
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public VerticalAlignmentKind? BaseJustification
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public BooleanKind? HidePlaceholder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public MatrixColumns? MatrixColumns
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
