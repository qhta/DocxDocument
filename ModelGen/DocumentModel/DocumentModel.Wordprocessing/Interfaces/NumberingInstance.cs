namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public interface NumberingInstance
{
  /// <summary>
  /// numId
  /// </summary>
  public Int32? NumberID { get ; set; }
  
  /// <summary>
  /// durableId
  /// </summary>
  public Int32? DurableId { get ; set; }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public Int32? AbstractNumId { get ; set; }
  
  public Collection<LevelOverride>? LevelOverrides { get ; set; }
  
}
