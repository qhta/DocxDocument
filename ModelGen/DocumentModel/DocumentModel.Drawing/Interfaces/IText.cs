namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Text Class.
/// </summary>
public interface IText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TextData.
  /// </summary>
  public DocumentModel.Drawing.ITextData? TextData { get ; set; }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public DocumentModel.Drawing.IRichTextBody? RichTextBody { get ; set; }
  
}
