namespace DocumentModel.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public interface Field
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get ; set; }
  
}
