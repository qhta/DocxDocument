namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public interface IBlipExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IImageProperties? ImageProperties { get ; set; }
  
  public Boolean? UseLocalDpi { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawing.IWebVideoProperty? WebVideoProperty { get ; set; }
  
  public ISVGBlip? SVGBlip { get ; set; }
  
  public IPictureAttributionSourceURL? PictureAttributionSourceURL { get ; set; }
  
  public DocumentModel.Wordprocessing.IOEmbed? OEmbed { get ; set; }
  
  public IOEmbedShared? OEmbedShared { get ; set; }
  
}
