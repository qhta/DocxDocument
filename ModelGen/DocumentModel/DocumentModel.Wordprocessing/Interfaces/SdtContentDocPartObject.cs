namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public interface SdtContentDocPartObject // : DocumentModel.Wordprocessing.SdtDocPartType
{
  public String? DocPartGallery { get ; set; }
  
  public String? DocPartCategory { get ; set; }
  
  public Boolean? DocPartUnique { get ; set; }
  
}
