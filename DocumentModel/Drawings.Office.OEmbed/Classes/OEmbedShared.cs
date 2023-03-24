namespace DocumentModel.Drawings.Office.OEmbed;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public class OEmbedShared: ModelElement
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
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}