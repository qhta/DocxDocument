namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartList Class.
/// </summary>
public class SdtContentDocPartListImpl: DocumentModel.Wordprocessing.SdtDocPartTypeImpl, SdtContentDocPartList
{
  public new DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? DocPartGallery
  {
    get;
    set;
  }
  
  public override String? DocPartCategory
  {
    get;
    set;
  }
  
  public override Boolean? DocPartUnique
  {
    get;
    set;
  }
  
}
