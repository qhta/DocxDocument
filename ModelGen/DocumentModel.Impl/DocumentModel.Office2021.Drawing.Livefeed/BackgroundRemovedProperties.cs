namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the BackgroundRemovedProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList))]
public class BackgroundRemovedProperties: IBackgroundRemovedProperties
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
