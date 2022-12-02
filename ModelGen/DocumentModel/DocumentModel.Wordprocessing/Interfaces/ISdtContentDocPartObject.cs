namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public interface ISdtContentDocPartObject // : DocumentModel.Wordprocessing.ISdtDocPartType
{
  public String? DocPartGallery { get ; set; }
  
  public String? DocPartCategory { get ; set; }
  
  public Boolean? DocPartUnique { get ; set; }
  
}
