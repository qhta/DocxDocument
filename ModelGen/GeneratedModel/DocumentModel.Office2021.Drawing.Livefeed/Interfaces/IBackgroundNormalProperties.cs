namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the BackgroundNormalProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList))]
public interface IBackgroundNormalProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
