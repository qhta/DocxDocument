namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TrackChangeType Class.
/// </summary>
public class TrackChangeType: ModelElement, IRangeMarkupElement, ICommonContent
{
  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }
  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
}