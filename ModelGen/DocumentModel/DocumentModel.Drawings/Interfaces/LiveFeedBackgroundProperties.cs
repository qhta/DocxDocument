namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public partial interface LiveFeedBackgroundProperties
{
  public DocumentModel.Drawings.BackgroundNormalProperties? BackgroundNormalProperties { get; set; }
  
  public DocumentModel.Drawings.BackgroundRemovedProperties? BackgroundRemovedProperties { get; set; }
  
  public DocumentModel.Drawings.BackgroundBlurProperties? BackgroundBlurProperties { get; set; }
  
  public DocumentModel.Drawings.BackgroundCustomProperties? BackgroundCustomProperties { get; set; }
  
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
