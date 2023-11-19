namespace DocumentModel.WebExtensionsPane;


/// <summary>
///   Defines the WebExtensionPartReference Class.
/// </summary>
public partial class WebExtensionPartReference: ModelElement<DXO13WEP.WebExtensionPartReference>
{
  public WebExtensionPartReference(): base(){ }
  
  public WebExtensionPartReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtensionPartReference(DXO13WEP.WebExtensionPartReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
