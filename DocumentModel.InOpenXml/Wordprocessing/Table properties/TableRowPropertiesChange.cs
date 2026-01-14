namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a change to table row properties, used in <see cref="TableRowProperties"/>.
/// This interface annotates <see cref="PreviousTableRowProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for table rows.
/// </summary>
public class TableRowPropertiesChange: ModelElement
{
  
  /// <summary>
  /// Author of the change to the table row properties.
  /// </summary>
  public string? Author { get; set; }
  
  /// <summary>
  /// Date of the change to the table row properties.
  /// </summary>
  public DateTime? Date { get; set; }
  
  /// <summary>
  /// Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? AnnotationId { get; set; }
  
  /// <summary>
  /// Previous table row properties before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousTableRowProperties? PreviousTableRowProperties { get; set; }
}