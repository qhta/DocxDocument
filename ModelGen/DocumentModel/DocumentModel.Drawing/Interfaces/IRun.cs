namespace DocumentModel.Drawing;

/// <summary>
/// Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawing.ITextCharacterPropertiesType? RunProperties { get ; set; }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Text { get ; set; }
  
}
