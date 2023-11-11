namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundBlurProperties Class.
/// </summary>
public partial class BackgroundBlurProperties: ModelElement<DXO21DL.BackgroundBlurProperties>
{
  public BackgroundBlurProperties(): base(){ }
  
  public BackgroundBlurProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundBlurProperties(DXO21DL.BackgroundBlurProperties openXmlElement): base(openXmlElement) { }
  
  
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
