namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a change to table cell properties, used in <see cref="TableCellProperties"/>.
///   This interface annotates <see cref="PreviousTableCellProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions in table cells.
/// </summary>
public class TableCellPropertiesChange: ModelElement
{
  /// <summary>
  ///   Author of the change to the table cell properties.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   Date of the change to the table cell properties.
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? AnnotationId { get; set; }

  /// <summary>
  ///   Previous table cell properties before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousTableCellProperties? PreviousTableCellProperties { get; set; }
}