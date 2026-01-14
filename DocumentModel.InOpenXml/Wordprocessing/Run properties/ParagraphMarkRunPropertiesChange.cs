namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a change to paragraph mark run properties, used in <see cref="ParagraphMarkRunProperties"/>.
/// This interface annotates <see cref="PreviousParagraphMarkRunProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for paragraph mark formatting.
/// </summary>
public class ParagraphMarkRunPropertiesChange: ModelElement
{
  /// <summary>
  /// Author of the change to the paragraph mark run properties.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  /// Date of the change to the paragraph mark run properties.
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  /// Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? AnnotationId { get; set; }

  /// <summary>
  /// Previous run properties for the paragraph mark before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties { get; set; }
}