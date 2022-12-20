namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public partial interface LevelOverride
{
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  public Int32? LevelIndex { get; set; }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  public Int32? StartOverrideNumberingValue { get; set; }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public DocumentModel.Wordprocessing.Level? Level { get; set; }
  
}
