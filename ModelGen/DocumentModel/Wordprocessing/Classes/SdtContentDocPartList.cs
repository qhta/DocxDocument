namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of a document part gallery type.
/// </summary>
public partial class SdtContentDocPartList
{
  public String? DocPartGallery { get; set; }
  
  public String? DocPartCategory { get; set; }
  
  public Boolean? DocPartUnique { get; set; }
  
}
