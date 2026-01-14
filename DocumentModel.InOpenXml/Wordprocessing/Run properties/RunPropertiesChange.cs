namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a change to run properties, used in <see cref="RunProperties"/>.
/// This interface annotates <see cref="PreviousRunProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for text runs.
/// </summary>
public class RunPropertiesChange: ModelElement
{
  
  /// <summary>
  /// Author of the change to the run properties.
  /// </summary>
  public string? Author { get; set; }
  
  /// <summary>
  /// Date of the change to the run properties.
  /// </summary>
  public DateTime? Date { get; set; }
  
  /// <summary>
  /// Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? AnnotationId { get; set; }
  
  /// <summary>
  /// Previous run properties before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousRunProperties? PreviousRunProperties { get; set; }
}