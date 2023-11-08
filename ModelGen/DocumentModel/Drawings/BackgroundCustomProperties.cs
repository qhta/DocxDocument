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
