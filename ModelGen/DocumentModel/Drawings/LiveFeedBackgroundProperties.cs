namespace DocumentModel.Drawings;


/// <summary>
///   Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public partial class LiveFeedBackgroundProperties
{
  public DMD.BackgroundNormalProperties? BackgroundNormalProperties { get; set; }
  
  public DMD.BackgroundRemovedProperties? BackgroundRemovedProperties { get; set; }
  
  public DMD.BackgroundBlurProperties? BackgroundBlurProperties { get; set; }
  
  public DMD.BackgroundCustomProperties? BackgroundCustomProperties { get; set; }
  
  public DMD.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
