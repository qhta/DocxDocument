namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the WebExtensionProperty Class.
/// </summary>
public partial class WebExtensionProperty: ModelElement<DXO13WE.WebExtensionProperty>
{
  public WebExtensionProperty(): base(){ }
  
  public WebExtensionProperty(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtensionProperty(DXO13WE.WebExtensionProperty openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   value, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Value
  {
    get => _Element?.Value;
    set => _ExistingElement.Value = value;
  }
  
}
