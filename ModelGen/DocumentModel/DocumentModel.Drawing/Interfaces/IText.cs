namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Text Class.
/// </summary>
public interface IText // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TextData.
  /// </summary>
  public ITextData? TextData { get ; set; }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public IRichTextBody? RichTextBody { get ; set; }
  
}
