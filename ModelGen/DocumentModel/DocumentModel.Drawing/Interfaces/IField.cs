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
  public DocumentModel.Drawing.ITextCharacterPropertiesType? RunProperties { get ; set; }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? ParagraphProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Text { get ; set; }
  
}
