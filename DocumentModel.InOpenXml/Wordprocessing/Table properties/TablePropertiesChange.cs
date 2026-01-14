namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a change to table properties, used in <see cref="TableProperties"/>.
///   This interface annotates <see cref="PreviousTableProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for tables.
/// </summary>
public class TablePropertiesChange: ModelElement
{
  /// <summary>
  ///   Author of the change to the table properties.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   Date of the change to the table properties.
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? AnnotationId { get; set; }

  /// <summary>
  ///   Previous table properties before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousTableProperties? PreviousTableProperties { get; set; }
}