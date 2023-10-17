namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of a document part type.
/// </summary>
public partial class SdtContentDocPartObject
{
  public DocumentModel.Wordprocessing.DocPartGallery? DocPartGallery { get; set; }
  
  public DocumentModel.Wordprocessing.DocPartCategory? DocPartCategory { get; set; }
  
  public DocumentModel.Wordprocessing.DocPartUnique? DocPartUnique { get; set; }
  
}
