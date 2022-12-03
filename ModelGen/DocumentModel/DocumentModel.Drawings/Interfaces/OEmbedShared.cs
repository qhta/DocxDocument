namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public interface OEmbedShared // : DocumentModel.BaseTypes.ModelElement
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
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
