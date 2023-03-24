namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Numbering Level Text.
/// </summary>
public class LevelText: ModelElement
{
  /// <summary>
  ///   Level Text
  /// </summary>
  public String? Val { get; set; }

  /// <summary>
  ///   Level Text Is Null Character
  /// </summary>
  public Boolean? Null { get; set; }
}