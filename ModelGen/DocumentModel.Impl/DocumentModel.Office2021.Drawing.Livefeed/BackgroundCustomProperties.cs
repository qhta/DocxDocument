namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the BackgroundCustomProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList))]
public class BackgroundCustomProperties: IBackgroundCustomProperties
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
