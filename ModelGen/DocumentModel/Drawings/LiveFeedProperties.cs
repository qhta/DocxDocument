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
      return _Element?.GetObject<DMD.LiveFeedBackgroundProperties,DXO21DL.LiveFeedBackgroundProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LiveFeedBackgroundProperties,DXO21DL.LiveFeedBackgroundProperties>(value);
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
      return _Element?.GetObject<DMD.OfficeArtExtensionList,DXO21DL.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.OfficeArtExtensionList,DXO21DL.OfficeArtExtensionList>(value);
    }
  }
  
}
