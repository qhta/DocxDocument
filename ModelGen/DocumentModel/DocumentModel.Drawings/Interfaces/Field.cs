namespace DocumentModel.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public interface Field // : DocumentModel.BaseTypes.ModelElement
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
  public RunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public String? Text { get ; set; }
  
}
