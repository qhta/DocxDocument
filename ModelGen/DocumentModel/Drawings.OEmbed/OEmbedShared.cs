namespace DocumentModel.Drawings.OEmbed;


/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public partial class OEmbedShared
{
  
  /// <summary>
  ///   srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? SrcUrl { get; set; }
  
  
  /// <summary>
  ///   type, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Type { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DMDOE.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
