namespace DocumentModel.Wordprocessing;

/// <summary>
/// Move Destination Paragraph.
/// </summary>
public interface IMoveTo // : DocumentFormat.OpenXml.Wordprocessing.TrackChangeType
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
