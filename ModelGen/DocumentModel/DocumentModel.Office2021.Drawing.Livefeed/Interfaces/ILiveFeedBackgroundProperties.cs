namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public interface ILiveFeedBackgroundProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Office2021.Drawing.Livefeed.IBackgroundNormalProperties? BackgroundNormalProperties { get ; set; }
  
  public DocumentModel.Office2021.Drawing.Livefeed.IBackgroundRemovedProperties? BackgroundRemovedProperties { get ; set; }
  
  public DocumentModel.Office2021.Drawing.Livefeed.IBackgroundBlurProperties? BackgroundBlurProperties { get ; set; }
  
  public DocumentModel.Office2021.Drawing.Livefeed.IBackgroundCustomProperties? BackgroundCustomProperties { get ; set; }
  
  public DocumentModel.Office2021.Drawing.Livefeed.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
