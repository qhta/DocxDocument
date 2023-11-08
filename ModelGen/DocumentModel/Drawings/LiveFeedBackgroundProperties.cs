namespace DocumentModel.Drawings;


/// <summary>
///   Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public partial class LiveFeedBackgroundProperties: ModelElement<DXO21DL.LiveFeedBackgroundProperties>
{
  public LiveFeedBackgroundProperties(): base(){ }
  
  public LiveFeedBackgroundProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LiveFeedBackgroundProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.BackgroundNormalProperties? BackgroundNormalProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DL.BackgroundNormalProperties>();
      if (element != null)
        return BackgroundNormalPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DL.BackgroundNormalProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundNormalPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundNormalProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BackgroundRemovedProperties? BackgroundRemovedProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DL.BackgroundRemovedProperties>();
      if (element != null)
        return BackgroundRemovedPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DL.BackgroundRemovedProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundRemovedPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundRemovedProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BackgroundBlurProperties? BackgroundBlurProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DL.BackgroundBlurProperties>();
      if (element != null)
        return BackgroundBlurPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DL.BackgroundBlurProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundBlurPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundBlurProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BackgroundCustomProperties? BackgroundCustomProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DL.BackgroundCustomProperties>();
      if (element != null)
        return BackgroundCustomPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DL.BackgroundCustomProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundCustomPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundCustomProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DL.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DL.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO21DL.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
