namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ParagraphPropertiesChange Class.
/// </summary>
public class ParagraphPropertiesChange: ModelElement
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
  ///   Previous Paragraph Properties.
  /// </summary>
  public ParagraphPropertiesExtended? ParagraphPropertiesExtended { get; set; }
}