namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the WebExtensionBinding Class.
/// </summary>
public partial class WebExtensionBinding: ModelElement<DXO13WE.WebExtensionBinding>
{
  public WebExtensionBinding(): base(){ }
  
  public WebExtensionBinding(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtensionBinding(DXO13WE.WebExtensionBinding openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   type, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Type
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Type);
    }
    set
    {
      _ExistingElement.Type = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   appref, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? AppReference
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AppReference);
    }
    set
    {
      _ExistingElement.AppReference = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMEX.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13WE.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WE.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13WE.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
