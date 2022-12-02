namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public interface ILiveFeedProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public ILiveFeedBackgroundProperties? LiveFeedBackgroundProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
