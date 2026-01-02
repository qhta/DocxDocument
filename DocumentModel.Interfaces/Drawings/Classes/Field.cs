namespace DocumentModel.Drawings;

/// <summary>
///   Text Field.
/// </summary>
public class Field: ModelElement
{
  /// <summary>
  ///   Field ID
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Field Type
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }
  /// <summary>
  ///   Text.
  /// </summary>
  public string? Text { get; set; }
}