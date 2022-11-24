namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
public interface IImageLayer // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Embed { get ; set; }
  
}
