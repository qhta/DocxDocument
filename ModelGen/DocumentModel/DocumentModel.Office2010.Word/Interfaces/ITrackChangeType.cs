namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the TrackChangeType Class.
/// </summary>
public interface ITrackChangeType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get ; set; }
  
}
