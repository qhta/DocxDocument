namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtDocPartType Class.
/// </summary>
public partial class SdtDocPartType: ModelElement<DXW.SdtDocPartType>
{
  public SdtDocPartType(): base(){ }
  
  public SdtDocPartType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtDocPartType(DXW.SdtDocPartType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Part Gallery Filter.
  /// </summary>
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
  
  
  /// <summary>
  ///   Document Part Category Filter.
  /// </summary>
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
  
  
  /// <summary>
  ///   Built-In Document Part.
  /// </summary>
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
