namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
public interface IImageLayer // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Embed { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IImageEffect>? ImageEffects { get ; set; }
  
}
