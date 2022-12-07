namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public interface LineNumberType
{
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  public LineNumberRestartKind? Restart { get ; set; }
  
}
