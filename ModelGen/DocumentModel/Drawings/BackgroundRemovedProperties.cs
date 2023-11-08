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
