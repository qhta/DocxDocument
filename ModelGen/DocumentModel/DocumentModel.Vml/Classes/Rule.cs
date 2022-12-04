namespace DocumentModel.Vml;

/// <summary>
/// Rule.
/// </summary>
public class Rule
{
  /// <summary>
  /// Rule Type
  /// </summary>
  public RuleKind? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public AlignmentKind? How
  {
    get;
    set;
  }
  
}
