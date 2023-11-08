namespace DocumentModel.Drawings;


/// <summary>
///   Defines the LiveFeedProperties Class.
/// </summary>
public partial class LiveFeedProperties: ModelElement<DXO21DL.LiveFeedProperties>
{
  public LiveFeedProperties(): base(){ }
  
  public LiveFeedProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LiveFeedProperties(DXO21DL.LiveFeedProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LiveFeedBackgroundProperties.
  /// </summary>
  [DataMember]
  public DMD.LiveFeedBackgroundProperties? LiveFeedBackgroundProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DL.LiveFeedBackgroundProperties>();
      if (element != null)
        return LiveFeedBackgroundPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DL.LiveFeedBackgroundProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LiveFeedBackgroundPropertiesConverter.CreateOpenXmlElement<DXO21DL.LiveFeedBackgroundProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
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
