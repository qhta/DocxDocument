namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Rich Text.
/// </summary>
public partial class RichText: ModelElement<DXDC.RichText>
{
  public RichText(): base(){ }
  
  public RichText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RichText(DXDC.RichText openXmlElement): base(openXmlElement) { }
  
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
