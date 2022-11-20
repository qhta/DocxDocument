namespace DocumentModel.Office.Drawing.Y2021.OEmbed;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.Y2021.OEmbed.IOfficeArtExtensionList))]
public interface IOEmbedShared // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? SrcUrl { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? Type { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office.Drawing.Y2021.OEmbed.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
