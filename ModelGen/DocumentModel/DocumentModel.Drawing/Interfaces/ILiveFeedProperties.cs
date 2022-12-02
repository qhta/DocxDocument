namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public interface ILiveFeedProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public DocumentModel.Drawing.ILiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
