namespace DocumentModel.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public interface TabStop
{
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public TextTabAlignmentKind? Alignment { get ; set; }
  
}
