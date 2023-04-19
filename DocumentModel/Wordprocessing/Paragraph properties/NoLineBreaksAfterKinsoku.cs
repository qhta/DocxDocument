namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Custom Set of Characters Which Cannot End a Line.
/// </summary>
public class NoLineBreaksAfterKinsoku: ModelElement
{
  /// <summary>
  ///   lang
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   val
  /// </summary>
  public string? Val { get; set; }
}