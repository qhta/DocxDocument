namespace DocumentModel.Drawing;

/// <summary>
/// Text Field.
/// </summary>
public interface IField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field ID
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Field Type
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawing.IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawing.IParagraphProperties? ParagraphProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public System.String? Text { get ; set; }
  
}
