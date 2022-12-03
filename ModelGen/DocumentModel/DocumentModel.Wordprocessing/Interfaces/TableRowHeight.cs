namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public interface TableRowHeight // : System.Boolean
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  public UInt32? Val { get ; set; }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  public HeightRuleKind? HeightType { get ; set; }
  
}
