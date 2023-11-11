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
      return _Element?.GetObject<DMEX.OfficeArtExtensionList,DXO13WE.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMEX.OfficeArtExtensionList,DXO13WE.OfficeArtExtensionList>(value);
    }
  }
  
}
