namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the TextProperties Class.
/// </summary>
public partial class TextProperties: ModelElement<DXDC.TextProperties>
{
  public TextProperties(): base(){ }
  
  public TextProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextProperties(DXDC.TextProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
