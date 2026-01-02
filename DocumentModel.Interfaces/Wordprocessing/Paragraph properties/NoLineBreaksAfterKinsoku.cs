namespace DocumentModel.Wordprocessing;

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