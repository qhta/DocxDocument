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
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   type, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Type
  {
    get => _Element?.Type;
    set => _ExistingElement.Type = value;
  }
  
  
  /// <summary>
  ///   appref, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? AppReference
  {
    get => _Element?.AppReference;
    set => _ExistingElement.AppReference = value;
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMEX.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
