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
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   value, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Value
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Value);
    }
    set
    {
      _ExistingElement.Value = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
