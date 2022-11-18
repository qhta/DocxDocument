namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IImageProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IUseLocalDpi))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.IPictureAttributionSourceURL))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.Y2021.OEmbed.IOEmbedShared))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.SVG.ISVGBlip))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.Y2020.OEmbed.IOEmbed))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Word.Drawing.IWebVideoProperty))]
public interface IBlipExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
