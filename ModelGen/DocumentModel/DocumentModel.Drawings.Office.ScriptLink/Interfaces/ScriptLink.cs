namespace DocumentModel.Drawings.Office.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public partial interface ScriptLink
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Val { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Office.ScriptLink.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
