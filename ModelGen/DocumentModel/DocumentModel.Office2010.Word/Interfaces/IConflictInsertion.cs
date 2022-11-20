namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ConflictInsertion Class.
/// </summary>
public interface IConflictInsertion // : DocumentFormat.OpenXml.Office2010.Word.TrackChangeType
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
