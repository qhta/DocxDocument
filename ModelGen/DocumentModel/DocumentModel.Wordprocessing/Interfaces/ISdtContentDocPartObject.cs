namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public interface ISdtContentDocPartObject // : DocumentModel.Wordprocessing.ISdtDocPartType
{
  public System.String? DocPartGallery { get ; set; }
  
  public System.String? DocPartCategory { get ; set; }
  
  public System.Boolean? DocPartUnique { get ; set; }
  
}
