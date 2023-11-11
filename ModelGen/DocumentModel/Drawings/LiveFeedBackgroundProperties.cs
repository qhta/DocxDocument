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
      return _Element?.GetObject<DMD.BackgroundNormalProperties,DXO21DL.BackgroundNormalProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BackgroundNormalProperties,DXO21DL.BackgroundNormalProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.BackgroundRemovedProperties? BackgroundRemovedProperties
  {
    get
    {
      return _Element?.GetObject<DMD.BackgroundRemovedProperties,DXO21DL.BackgroundRemovedProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BackgroundRemovedProperties,DXO21DL.BackgroundRemovedProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.BackgroundBlurProperties? BackgroundBlurProperties
  {
    get
    {
      return _Element?.GetObject<DMD.BackgroundBlurProperties,DXO21DL.BackgroundBlurProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BackgroundBlurProperties,DXO21DL.BackgroundBlurProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.BackgroundCustomProperties? BackgroundCustomProperties
  {
    get
    {
      return _Element?.GetObject<DMD.BackgroundCustomProperties,DXO21DL.BackgroundCustomProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BackgroundCustomProperties,DXO21DL.BackgroundCustomProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.OfficeArtExtensionList,DXO21DL.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.OfficeArtExtensionList,DXO21DL.OfficeArtExtensionList>(value);
    }
  }
  
}
