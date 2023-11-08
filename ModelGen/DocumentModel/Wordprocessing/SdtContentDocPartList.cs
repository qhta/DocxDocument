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
      var element = _Element?.GetFirstChild<DXW.DocPartGallery>();
      if (element != null)
        return DocPartGalleryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocPartGallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartGalleryConverter.CreateOpenXmlElement<DXW.DocPartGallery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DocPartCategory? DocPartCategory
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocPartCategory>();
      if (element != null)
        return DocPartCategoryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocPartCategory>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartCategoryConverter.CreateOpenXmlElement<DXW.DocPartCategory>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DocPartUnique? DocPartUnique
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocPartUnique>();
      if (element != null)
        return DocPartUniqueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocPartUnique>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartUniqueConverter.CreateOpenXmlElement<DXW.DocPartUnique>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
