namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of a document part gallery type.
/// </summary>
public partial class SdtContentDocPartList: ModelElement<DXW.SdtContentDocPartList>
{
  public SdtContentDocPartList(): base(){ }
  
  public SdtContentDocPartList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentDocPartList(DXW.SdtContentDocPartList openXmlElement): base(openXmlElement) { }
  
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
