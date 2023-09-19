namespace DocumentModel.Drawings.Office.OEmbed;


/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public partial class OEmbedShared
{
  
  /// <summary>
  ///   srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  [SchemaAttr("srcUrl")]
  public String? SrcUrl { get; set; }
  
  
  /// <summary>
  ///   type, this property is only available in Microsoft365 and later.
  /// </summary>
  [SchemaAttr("type")]
  public String? Type { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Office.OEmbed.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
