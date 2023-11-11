namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundNormalProperties Class.
/// </summary>
public partial class BackgroundNormalProperties: ModelElement<DXO21DL.BackgroundNormalProperties>
{
  public BackgroundNormalProperties(): base(){ }
  
  public BackgroundNormalProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundNormalProperties(DXO21DL.BackgroundNormalProperties openXmlElement): base(openXmlElement) { }
  
  
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
