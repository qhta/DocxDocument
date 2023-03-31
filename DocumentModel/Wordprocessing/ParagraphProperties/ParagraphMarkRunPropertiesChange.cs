namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public class ParagraphMarkRunPropertiesChange: ModelElement
{
  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties { get; set; }
}