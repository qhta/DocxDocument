namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public interface IBlipExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IImageProperties? ImageProperties { get ; set; }
  
  public System.Boolean? UseLocalDpi { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawing.IWebVideoProperty? WebVideoProperty { get ; set; }
  
  public DocumentModel.Drawing.ISVGBlip? SVGBlip { get ; set; }
  
  public DocumentModel.Drawing.IPictureAttributionSourceURL? PictureAttributionSourceURL { get ; set; }
  
  public DocumentModel.Wordprocessing.IOEmbed? OEmbed { get ; set; }
  
  public DocumentModel.Drawing.IOEmbedShared? OEmbedShared { get ; set; }
  
}
