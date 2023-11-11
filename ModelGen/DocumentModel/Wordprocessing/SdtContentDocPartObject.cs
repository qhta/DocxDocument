namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of a document part type.
/// </summary>
public partial class SdtContentDocPartObject: ModelElement<DXW.SdtContentDocPartObject>
{
  public SdtContentDocPartObject(): base(){ }
  
  public SdtContentDocPartObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentDocPartObject(DXW.SdtContentDocPartObject openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.DocPartGallery? DocPartGallery
  {
    get
    {
      return _Element?.GetObject<DMW.DocPartGallery,DXW.DocPartGallery>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartGallery,DXW.DocPartGallery>(value);
    }
  }
  
  [DataMember]
  public DMW.DocPartCategory? DocPartCategory
  {
    get
    {
      return _Element?.GetObject<DMW.DocPartCategory,DXW.DocPartCategory>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartCategory,DXW.DocPartCategory>(value);
    }
  }
  
  [DataMember]
  public DMW.DocPartUnique? DocPartUnique
  {
    get
    {
      return _Element?.GetObject<DMW.DocPartUnique,DXW.DocPartUnique>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartUnique,DXW.DocPartUnique>(value);
    }
  }
  
}
