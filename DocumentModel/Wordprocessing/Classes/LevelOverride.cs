namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LevelOverride Class.
/// </summary>
public class LevelOverride: ModelElement
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
  public Level? Level { get; set; }
}