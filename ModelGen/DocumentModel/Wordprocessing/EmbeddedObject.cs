namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that an embedded object is located at this position in the run’s contents. The layout properties of this embedded object, as well as an optional static representation, are specified using the drawing element.
/// </summary>
public partial class EmbeddedObject: ModelElement<DXW.EmbeddedObject>
{
  public EmbeddedObject(): base(){ }
  
  public EmbeddedObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbeddedObject(DXW.EmbeddedObject openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   dxaOrig
  /// </summary>
  [DataMember]
  public String? DxaOriginal
  {
    get => _Element?.DxaOriginal;
    set => _ExistingElement.DxaOriginal = value;
  }
  
  
  /// <summary>
  ///   dyaOrig
  /// </summary>
  [DataMember]
  public String? DyaOriginal
  {
    get => _Element?.DyaOriginal;
    set => _ExistingElement.DyaOriginal = value;
  }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? AnchorId
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  [DataMember]
  public DMW.Drawing? Drawing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW.Control? Control
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMW.ObjectEmbed? ObjectEmbed
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMW.ObjectLink? ObjectLink
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
