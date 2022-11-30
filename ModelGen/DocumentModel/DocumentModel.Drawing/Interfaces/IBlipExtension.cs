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
  
  public DocumentModel.Office2010.Drawing.IImageProperties? ImageProperties { get ; set; }
  
  public System.Boolean? UseLocalDpi { get ; set; }
  
  public DocumentModel.Office2013.Word.Drawing.IWebVideoProperty? WebVideoProperty { get ; set; }
  
  public DocumentModel.Office2019.Drawing.SVG.ISVGBlip? SVGBlip { get ; set; }
  
  public DocumentModel.Office2019.Drawing.IPictureAttributionSourceURL? PictureAttributionSourceURL { get ; set; }
  
  public DocumentModel.Office.Word.Y2020.OEmbed.IOEmbed? OEmbed { get ; set; }
  
  public DocumentModel.Office.Drawing.Y2021.OEmbed.IOEmbedShared? OEmbedShared { get ; set; }
  
}
