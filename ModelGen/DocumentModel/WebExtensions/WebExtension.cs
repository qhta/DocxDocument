namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the WebExtension Class.
/// </summary>
public partial class WebExtension: ModelElement<DXO13WE.WebExtension>
{
  public WebExtension(): base(){ }
  
  public WebExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtension(DXO13WE.WebExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   frozen, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Frozen
  {
    get => _Element?.Frozen?.Value;
    set => _ExistingElement.Frozen = value;
  }
  
  
  /// <summary>
  ///   WebExtensionStoreReference.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionStoreReference? WebExtensionStoreReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   WebExtensionReferenceList.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionReferenceList? WebExtensionReferenceList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   WebExtensionPropertyBag.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionPropertyBag? WebExtensionPropertyBag
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   WebExtensionBindingList.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionBindingList? WebExtensionBindingList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Snapshot.
  /// </summary>
  [DataMember]
  public DMEX.Snapshot? Snapshot
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMEX.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
