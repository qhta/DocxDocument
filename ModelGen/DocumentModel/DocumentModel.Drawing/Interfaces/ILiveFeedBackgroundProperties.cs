namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public interface ILiveFeedBackgroundProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.IBackgroundNormalProperties? BackgroundNormalProperties { get ; set; }
  
  public DocumentModel.Drawing.IBackgroundRemovedProperties? BackgroundRemovedProperties { get ; set; }
  
  public DocumentModel.Drawing.IBackgroundBlurProperties? BackgroundBlurProperties { get ; set; }
  
  public DocumentModel.Drawing.IBackgroundCustomProperties? BackgroundCustomProperties { get ; set; }
  
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
