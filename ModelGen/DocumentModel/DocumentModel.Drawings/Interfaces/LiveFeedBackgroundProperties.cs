namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public interface LiveFeedBackgroundProperties // : DocumentModel.BaseTypes.ModelElement
{
  public BackgroundNormalProperties? BackgroundNormalProperties { get ; set; }
  
  public BackgroundRemovedProperties? BackgroundRemovedProperties { get ; set; }
  
  public BackgroundBlurProperties? BackgroundBlurProperties { get ; set; }
  
  public BackgroundCustomProperties? BackgroundCustomProperties { get ; set; }
  
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
