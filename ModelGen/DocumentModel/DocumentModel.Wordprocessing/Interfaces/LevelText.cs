namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public interface LevelText
{
  /// <summary>
  /// Level Text
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  public Boolean? Null { get ; set; }
  
}
