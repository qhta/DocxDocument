namespace DocumentModel.WebExtensionsPane;


/// <summary>
///   Defines the WebExtensionTaskpane Class.
/// </summary>
public partial class WebExtensionTaskpane: ModelElement<DXO13WEP.WebExtensionTaskpane>
{
  public WebExtensionTaskpane(): base(){ }
  
  public WebExtensionTaskpane(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtensionTaskpane(DXO13WEP.WebExtensionTaskpane openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? DockState
  {
    get => _Element?.DockState;
    set => _ExistingElement.DockState = value;
  }
  
  
  /// <summary>
  ///   visibility, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visibility
  {
    get => _Element?.Visibility?.Value;
    set => _ExistingElement.Visibility = value;
  }
  
  
  /// <summary>
  ///   width, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Double? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   row, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Row
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   locked, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Locked
  {
    get => _Element?.Locked?.Value;
    set => _ExistingElement.Locked = value;
  }
  
  
  /// <summary>
  ///   WebExtensionPartReference.
  /// </summary>
  [DataMember]
  public DMWEP.WebExtensionPartReference? WebExtensionPartReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMWEP.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
