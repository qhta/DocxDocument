namespace DocumentModel.Wordprocessing;

/// <summary>
/// Legacy Numbering Level Properties.
/// </summary>
public class LegacyNumbering: ILegacyNumbering
{
  /// <summary>
  /// Use Legacy Numbering Properties
  /// </summary>
  public bool? Legacy
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legacy Spacing
  /// </summary>
  public string? LegacySpace
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legacy Indent
  /// </summary>
  public string? LegacyIndent
  {
    get;
    set;
  }
  
}
