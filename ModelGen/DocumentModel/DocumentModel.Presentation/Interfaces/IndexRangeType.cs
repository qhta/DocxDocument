namespace DocumentModel.Presentation;

/// <summary>
/// Defines the IndexRangeType Class.
/// </summary>
public interface IndexRangeType // : System.Boolean
{
  /// <summary>
  /// Start
  /// </summary>
  public UInt32? Start { get ; set; }
  
  /// <summary>
  /// End
  /// </summary>
  public UInt32? End { get ; set; }
  
}
