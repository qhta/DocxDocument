namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public interface DocPartName // : System.Boolean
{
  /// <summary>
  /// Name Value
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  public Boolean? Decorated { get ; set; }
  
}
