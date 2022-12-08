namespace DocumentModel.Wordprocessing;

/// <summary>
/// Legacy Numbering Level Properties.
/// </summary>
public interface LegacyNumbering
{
  /// <summary>
  /// Use Legacy Numbering Properties
  /// </summary>
  public Boolean? Legacy { get ; set; }
  
  /// <summary>
  /// Legacy Spacing
  /// </summary>
  public String? LegacySpace { get ; set; }
  
  /// <summary>
  /// Legacy Indent
  /// </summary>
  public String? LegacyIndent { get ; set; }
  
}
