namespace DocumentModel.Drawing;

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
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
