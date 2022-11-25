namespace DocumentModel.Drawing;

/// <summary>
/// Text Shape.
/// </summary>
public interface ITextShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Drawing.ITextBody? TextBody { get ; set; }
  
}
