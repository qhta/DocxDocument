namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundRemovedProperties Class.
/// </summary>
public partial class BackgroundRemovedProperties: ModelElement<DXO21DL.BackgroundRemovedProperties>
{
  public BackgroundRemovedProperties(): base(){ }
  
  public BackgroundRemovedProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundRemovedProperties(DXO21DL.BackgroundRemovedProperties openXmlElement): base(openXmlElement) { }
  
  
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
