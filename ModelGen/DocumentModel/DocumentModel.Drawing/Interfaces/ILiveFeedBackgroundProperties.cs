namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public interface ILiveFeedBackgroundProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public IBackgroundNormalProperties? BackgroundNormalProperties { get ; set; }
  
  public IBackgroundRemovedProperties? BackgroundRemovedProperties { get ; set; }
  
  public IBackgroundBlurProperties? BackgroundBlurProperties { get ; set; }
  
  public IBackgroundCustomProperties? BackgroundCustomProperties { get ; set; }
  
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
