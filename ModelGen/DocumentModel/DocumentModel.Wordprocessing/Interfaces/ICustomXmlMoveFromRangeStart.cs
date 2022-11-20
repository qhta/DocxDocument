namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlMoveFromRangeStart Class.
/// </summary>
public interface ICustomXmlMoveFromRangeStart // : DocumentFormat.OpenXml.Wordprocessing.TrackChangeType
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
