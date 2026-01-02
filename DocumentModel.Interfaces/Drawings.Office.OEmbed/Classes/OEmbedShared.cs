namespace DocumentModel.Drawings.Office.OEmbed;

/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public class OEmbedShared: ModelElement
{
  /// <summary>
  ///   srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? SrcUrl { get; set; }
  /// <summary>
  ///   type, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}