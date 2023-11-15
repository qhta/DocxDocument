namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleSize Class.
/// </summary>
public partial class BubbleSize: ModelElement<DXDC.BubbleSize>
{
  public BubbleSize(): base(){ }
  
  public BubbleSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BubbleSize(DXDC.BubbleSize openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
  }
  
}
