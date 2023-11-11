namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundCustomProperties Class.
/// </summary>
public partial class BackgroundCustomProperties: ModelElement<DXO21DL.BackgroundCustomProperties>
{
  public BackgroundCustomProperties(): base(){ }
  
  public BackgroundCustomProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundCustomProperties(DXO21DL.BackgroundCustomProperties openXmlElement): base(openXmlElement) { }
  
  
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
