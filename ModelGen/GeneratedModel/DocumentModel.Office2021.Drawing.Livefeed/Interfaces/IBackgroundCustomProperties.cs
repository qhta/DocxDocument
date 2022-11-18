namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the BackgroundCustomProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList))]
public interface IBackgroundCustomProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
