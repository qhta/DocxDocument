namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IImageEffect))]
public interface IImageLayer // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Embed { get ; set; }
  
}
