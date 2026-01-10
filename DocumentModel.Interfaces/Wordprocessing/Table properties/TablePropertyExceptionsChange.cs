namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a change to table property exceptions, used in <see cref="TablePropertyExceptions"/>.
/// This interface annotates <see cref="PreviousTablePropertyExceptions"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for table-level exceptions.
/// </summary>
public interface TablePropertyExceptionsChange
{

  /// <summary>
  /// Author of the change to the table property exceptions.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  /// Date of the change to the table property exceptions.
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  /// Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? AnnotationId { get; set; }

  /// <summary>
  /// Previous table-level property exceptions before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousTablePropertyExceptions? PreviousTablePropertyExceptions { get; set; }
}