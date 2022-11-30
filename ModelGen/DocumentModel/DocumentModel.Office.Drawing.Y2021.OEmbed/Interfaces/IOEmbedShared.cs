namespace DocumentModel.Office.Drawing.Y2021.OEmbed;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public interface IOEmbedShared // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public System.String? SrcUrl { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office.Drawing.Y2021.OEmbed.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
