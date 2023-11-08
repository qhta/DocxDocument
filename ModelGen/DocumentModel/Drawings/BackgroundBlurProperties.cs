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
