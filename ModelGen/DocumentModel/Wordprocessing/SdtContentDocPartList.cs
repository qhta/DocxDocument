namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of a document part gallery type.
/// </summary>
public partial class SdtContentDocPartList
{
  public DMW.DocPartGallery? DocPartGallery { get; set; }
  
  public DMW.DocPartCategory? DocPartCategory { get; set; }
  
  public DMW.DocPartUnique? DocPartUnique { get; set; }
  
}
