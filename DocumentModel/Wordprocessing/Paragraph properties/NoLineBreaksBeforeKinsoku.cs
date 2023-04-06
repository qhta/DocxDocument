namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public class NoLineBreaksBeforeKinsoku: ModelElement
{
  /// <summary>
  ///   lang
  /// </summary>
  public String? Language { get; set; }

  /// <summary>
  ///   val
  /// </summary>
  public String? Val { get; set; }
}