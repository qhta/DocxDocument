namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public interface ILiveFeedProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? LiveFeedBackgroundProperties { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OfficeArtExtensionList { get ; set; }
  
}
