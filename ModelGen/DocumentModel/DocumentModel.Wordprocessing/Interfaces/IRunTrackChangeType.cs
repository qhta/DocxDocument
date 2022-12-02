namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public interface IRunTrackChangeType // : DocumentModel.ITypedOpenXmlCompositeElement
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
