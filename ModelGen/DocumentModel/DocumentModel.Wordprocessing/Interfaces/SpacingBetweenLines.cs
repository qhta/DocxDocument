namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public interface SpacingBetweenLines
{
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  public LineSpacingRuleKind? LineRule { get ; set; }
  
}
