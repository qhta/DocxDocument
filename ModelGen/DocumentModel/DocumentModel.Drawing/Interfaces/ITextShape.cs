namespace DocumentModel.Drawing;

/// <summary>
/// Text Shape.
/// </summary>
public interface ITextShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public ITextBody? TextBody { get ; set; }
  
}
