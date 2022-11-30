namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartList Class.
/// </summary>
public interface ISdtContentDocPartList // : DocumentModel.Wordprocessing.ISdtDocPartType
{
  public System.String? DocPartGallery { get ; set; }
  
  public System.String? DocPartCategory { get ; set; }
  
  public System.Boolean? DocPartUnique { get ; set; }
  
}
