namespace DocumentModel.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public interface TabStop // : System.Boolean
{
  /// <summary>
  /// Tab Position
  /// </summary>
  public Int32? Position { get ; set; }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public TextTabAlignmentKind? Alignment { get ; set; }
  
}
