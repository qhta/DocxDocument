namespace DocumentModel.Drawing;

/// <summary>
/// Text Field.
/// </summary>
public interface IField // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public IParagraphProperties? ParagraphProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public String? Text { get ; set; }
  
}
