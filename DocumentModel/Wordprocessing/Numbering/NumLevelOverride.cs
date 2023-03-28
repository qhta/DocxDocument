namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies an optional override which shall be applied in place of zero or more levels 
///   from the abstract numbering definition for a given numbering definition instance. 
///   Each instance of this element is used to override the appearance and behavior 
///   of a given numbering level definition within the given abstract numbering definition. 
/// </summary>
public class NumLevelOverride: ModelElement
{
  /// <summary>
  ///   Numbering Level ID
  /// </summary>
  public Int32? LevelIndex { get; set; }

  /// <summary>
  ///   Numbering Level Starting Value Override.
  /// </summary>
  public Int32? StartOverrideNumberingValue { get; set; }

  /// <summary>
  ///   Numbering Level Override Definition.
  /// </summary>
  public NumLevel? Level { get; set; }
}