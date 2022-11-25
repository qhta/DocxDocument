namespace DocumentModel.Drawing;

/// <summary>
/// Text Line Break.
/// </summary>
public interface IBreak // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public DocumentModel.Drawing.ITextCharacterPropertiesType? RunProperties { get ; set; }
  
}
