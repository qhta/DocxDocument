namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LevelOverride Class.
/// </summary>
public partial class LevelOverride
{
  
  /// <summary>
  ///   Numbering Level ID
  /// </summary>
  public Int32? LevelIndex { get; set; }
  
  
  /// <summary>
  ///   Numbering Level Starting Value Override.
  /// </summary>
  public DMW.StartOverrideNumberingValue? StartOverrideNumberingValue { get; set; }
  
  
  /// <summary>
  ///   Numbering Level Override Definition.
  /// </summary>
  public DMW.Level? Level { get; set; }
  
}
