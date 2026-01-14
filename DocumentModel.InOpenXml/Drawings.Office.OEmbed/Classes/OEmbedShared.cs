namespace DocumentModel.Drawings.Office.OEmbed;

/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public class OEmbedShared: ModelElement
{
  /// <summary>
  ///   srcUrl
  /// </summary>
  public string? SrcUrl { get; set; }
  /// <summary>
  ///   type
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}