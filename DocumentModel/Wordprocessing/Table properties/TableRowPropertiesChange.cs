namespace DocumentModel.Wordprocessing;

/// <summary>
///   Revision Information for Table Row Properties.
/// </summary>
public class TableRowPropertiesChange: ModelElement
{
  /// <summary>
  ///   Author.
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   Date.
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier.
  /// </summary>
  public String? AnnotationId { get; set; }

  /// <summary>
  ///   Previous Table Row Properties.
  /// </summary>
  public PreviousTableRowProperties? PreviousTableRowProperties { get; set; }
}