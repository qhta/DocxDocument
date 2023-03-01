namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TrackChangeType Class.
/// </summary>
public class TrackChangeType: BodyElement, ParagraphElement
{
  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
}