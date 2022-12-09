namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public interface OEmbedShared
{
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? SrcUrl { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList7? OfficeArtExtensionList { get ; set; }
  
}
