namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public class SdtContentDocPartObjectImpl: DocumentModel.Wordprocessing.SdtDocPartTypeImpl, SdtContentDocPartObject
{
  public new DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject?)_OpenXmlElement;
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
