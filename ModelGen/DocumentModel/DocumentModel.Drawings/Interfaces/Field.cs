namespace DocumentModel.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public interface Field
{
  /// <summary>
  /// Field ID
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Field Type
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawings.RunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawings.ParagraphProperties? ParagraphProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public String? Text { get ; set; }
  
}
